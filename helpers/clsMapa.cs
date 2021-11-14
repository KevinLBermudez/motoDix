using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMap.NET.MapProviders;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.Device.Location;
using System.Windows.Forms;
using System.Drawing;

namespace final_motoDix.helpers
{
    public struct datosRuta
    {
        private string tituloDato;
        private string dato;

        public string TituloDato { get => tituloDato; set => tituloDato = value; }
        public string Dato { get => dato; set => dato = value; }

        public datosRuta(string tituloDato, string dato) : this()
        {
            TituloDato = tituloDato;
            Dato = dato;
        }

    }


    class clsMapa
    {
        private datosRuta datos;
        PointLatLng posicionActual;
        PointLatLng puntoInicio;
        PointLatLng puntoFinal;
        GDirections directions;
        GMapOverlay capaInicio;
        GMapOverlay capaFinal;
        GMapOverlay capaRuta;
        public List<datosRuta> infoViajeRuta = new List<datosRuta>();


        public clsMapa()
        {


        }


        public void cargarConfiguracionesMapa(GMapControl map )
        {
            
            GMapProviders.GoogleMap.ApiKey = "AIzaSyD53-lwKKlRgkrmqM2kb19laYtq_BdG_RY";
            map.DragButton = MouseButtons.Left;
            map.MapProvider = GMapProviders.GoogleMap;
            map.Zoom = 10;
            map.ShowCenter = false;
            map.AutoScroll = false;
            PointLatLng defaultPoint = new PointLatLng(6.2509889857684655, -75.57290454506146);
            map.Position =  defaultPoint;
            map.Zoom = map.Zoom + 1;
            map.Zoom = map.Zoom - 1;

        }

        public bool activarPosicionActual(GMapControl map)
        {
            double lat;
            double lng;
            GeoCoordinateWatcher geo = new GeoCoordinateWatcher();

            try
            {
                geo.PositionChanged += (sen, eve) =>
                {
                    if(puntoInicio.IsEmpty == true || puntoFinal.IsEmpty == true)
                    {
                        lat = eve.Position.Location.Latitude;
                        lng = eve.Position.Location.Longitude;
                        posicionActual = new PointLatLng(lat, lng);
                        map.Position = posicionActual;
                        seleccionarPunto(posicionActual, map, "Posicion actual");
                        map.Zoom = 10;

                    }

                };
                if (!geo.TryStart(true, TimeSpan.FromSeconds(15)))
                {
                    MessageBox.Show("No se pudo obtener la ubicacion actual");
                }

                return true;

            }
            catch
            {
                MessageBox.Show("Error al obtener unicacion actual");
                return false;
            }
        }


        public void seleccionarPunto(PointLatLng punto, GMapControl map, string nombrePunto = "Punto inicial")
        {
           
            if(puntoInicio.IsEmpty)
            {
                var markers = new GMapOverlay("markers");
                GMapMarker marcador = new GMarkerGoogle(punto, GMarkerGoogleType.black_small);
                marcador.ToolTipText = nombrePunto;
                marcador.ToolTipMode = MarkerTooltipMode.Always;
                markers.Markers.Add(marcador);
                capaInicio = markers;
                map.Overlays.Add(capaInicio);
                puntoInicio = punto;
                map.Position = puntoInicio;

            }else if (puntoFinal.IsEmpty)
            {
                var markers = new GMapOverlay("markers");
                GMapMarker marcador = new GMarkerGoogle(punto, GMarkerGoogleType.black_small);
                marcador.ToolTipText = "Punto de destino";
                marcador.ToolTipMode = MarkerTooltipMode.Always;
                markers.Markers.Add(marcador);
                capaFinal = markers;
                map.Overlays.Add(capaFinal);
                puntoFinal = punto;

                calcularRuta(map);
            }

        }


        public void calcularRuta(GMapControl map)
        {
            
            GMapProviders.GoogleMap.GetDirections(out directions, puntoInicio, puntoFinal, false, false, false, false, false);

            GMapRoute route = new GMapRoute(directions.Route, "Ruta");

            GMapOverlay capaRutas = new GMapOverlay("Capa de ruta");
            capaRutas.Routes.Add(route);
            capaRuta = capaRutas;
            map.Overlays.Add(capaRuta);
            map.Zoom = map.Zoom + 1;
            map.Zoom = map.Zoom - 1;

            datos = new datosRuta("Distancia", directions.DistanceValue.ToString());
            infoViajeRuta.Add(datos);
            datos = new datosRuta("Duracción", directions.Duration.ToString());
            infoViajeRuta.Add(datos);
            datos = new datosRuta("Punto inicial", directions.StartAddress.ToString());
            infoViajeRuta.Add(datos);
            datos = new datosRuta("Punto final",directions.EndAddress.ToString());
            infoViajeRuta.Add(datos);

        }

        public void validarRuta()
        {
            if(capaRuta == null)
            {
                throw new ArgumentException("No se ha seleccionado una ruta", nameof(capaRuta));
            }
        }

        public void limpiarPuntos(GMapControl map)
        {
            map.Overlays.Clear();

        }
    }
}
