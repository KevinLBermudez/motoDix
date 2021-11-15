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

        private GMapControl map;
        private datosRuta datos;
        public PointLatLng posicionActual;
        public PointLatLng puntoInicio;
        public PointLatLng puntoFinal;
        PointLatLng error;
        GDirections directions;
        GMapOverlay capaInicio;
        GMapOverlay capaFinal;
        GMapOverlay capaRuta;
        public List<datosRuta> infoViajeRuta = new List<datosRuta>();
        public GMapControl Map { get => map; set => map = value; }


        public clsMapa(GMapControl map)
        {
            Map = map;

        }


        public void cargarConfiguracionesMapa()
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
                        seleccionarPunto(posicionActual, "Posicion actual");
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


        public void seleccionarPunto(PointLatLng punto, string nombrePunto = "Punto inicial")
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

                calcularRuta();
            }

        }


        public PointLatLng buscarPunto(string punto)
        {
            if (!validarRuta())
            {
                map.Overlays.Clear();
                PointLatLng puntoCoordenadas;
                map.SetPositionByKeywords(punto);
                map.GetPositionByKeywords(punto, out puntoCoordenadas);
                var markers = new GMapOverlay("markers");
                GMapMarker marcador = new GMarkerGoogle(puntoCoordenadas, GMarkerGoogleType.black_small);
                marcador.ToolTipText = "Punto encontrado";
                marcador.ToolTipMode = MarkerTooltipMode.Always;
                markers.Markers.Add(marcador);
                map.Overlays.Add(markers);

                return puntoCoordenadas;

            }
            else
            {
                return error;
            }
        }

        public bool calcularRuta()
        {
            
            GMapProviders.GoogleMap.GetDirections(out directions, puntoInicio, puntoFinal, false, false, false, false, false);
            try
            {
                GMapRoute route = new GMapRoute(directions.Route, "Ruta");
                GMapOverlay capaRutas = new GMapOverlay("Capa de ruta");
                capaRutas.Routes.Add(route);
                capaRuta = capaRutas;
                map.Overlays.Add(capaRuta);
                map.Zoom = map.Zoom + 1;
                map.Zoom = map.Zoom - 1;
                map.Position = puntoInicio;

                datos = new datosRuta("Distancia", directions.DistanceValue.ToString());
                infoViajeRuta.Add(datos);
                datos = new datosRuta("Duracción", directions.Duration.ToString());
                infoViajeRuta.Add(datos);
                datos = new datosRuta("Punto inicial", directions.StartAddress.ToString());
                infoViajeRuta.Add(datos);
                datos = new datosRuta("Punto final", directions.EndAddress.ToString());
                infoViajeRuta.Add(datos);

                return true;
            }
            catch (Exception)
            {
                throw new Exception( "No se pudo calcular la ruta");
            }

        }

        public bool calcularRutaTexto(PointLatLng inicio, PointLatLng final)
        {
            try
            {

                map.Overlays.Clear();

                var markers = new GMapOverlay("markers");
                GMapMarker marcador = new GMarkerGoogle(inicio, GMarkerGoogleType.black_small);
                marcador.ToolTipText = "Punto Inicio";
                marcador.ToolTipMode = MarkerTooltipMode.Always;
                markers.Markers.Add(marcador);
                map.Overlays.Add(markers);
                puntoInicio = inicio;

                GMapMarker marcador2 = new GMarkerGoogle(final, GMarkerGoogleType.black_small);
                marcador2.ToolTipText = "Destino";
                marcador2.ToolTipMode = MarkerTooltipMode.Always;
                markers.Markers.Add(marcador2);
                map.Overlays.Add(markers);
                puntoFinal = final;

                calcularRuta();

                return true;
            }
            catch (Exception)
            {
                throw new Exception("No se pudo calcular la ruta");
            }

        }

        public bool validarRuta()
        {
            if(capaRuta == null)
            {
                return false;
               // throw new ArgumentException("No se ha seleccionado una ruta", nameof(capaRuta));
            }
            return true;
        }

        public void limpiarPuntos(GMapControl map)
        {
            map.Overlays.Clear();

        }
    }
}
