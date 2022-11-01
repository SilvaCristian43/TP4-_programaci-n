using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd
{
    public class ListaJugadoresSuspendidos
    {

      public  DataTable DT { get; set; } = new DataTable();

        public bool comprobar { get; set; } = new bool();

        public ListaJugadoresSuspendidos() {

            DT.TableName = "suspendidos";

            DT.Columns.Add("DNI", typeof(int));
            DT.Columns.Add("NOMBRE", typeof (string));
            DT.Columns.Add("EQUIPO" , typeof(string));
            DT.Columns.Add("TARJETAS" , typeof(string));
            DT.Columns.Add("DIAS DE SUSPENSO",typeof(int));

            Examinararchivodt();


        }


        public void Examinararchivodt() {

            if (System.IO.File.Exists("ListaSuspendidos.xml"))
            {
                DT.ReadXml("ListaSuspendidos.xml");
                DT.WriteXml("ListaSuspendidos.xml");
            }
        
        
        }

        public void Cargardatos(Jugadores jugadores){

            DT.Rows.Add();
            int fila = DT.Rows.Count -1 ;

            DT.Rows[fila]["DNI"] = jugadores.DNI;
            DT.Rows[fila]["NOMBRE"] = jugadores.NOMBRE;
            DT.Rows[fila]["EQUIPO"] = jugadores.EQUIPO;
            DT.Rows[fila]["TARJETAS"] = jugadores.TARJETAS;
            DT.Rows[fila]["DIAS DE SUSPENSO"] = jugadores.DIASSUSPENCION;


            DT.WriteXml("ListaSuspendidos.xml");
        }

        public void Borrardatos(Jugadores jugadores){

            for (int i = 0; i < DT.Rows.Count; i++)
            {
                if (Convert.ToInt32(DT.Rows[i]["DNI"]) == jugadores.DNI)
                {
                    DT.Rows[i].Delete();
                }
            }

            DT.WriteXml("ListaSuspendidos.xml");

        }


        public void Actualizardatos(Jugadores jugadores) {

            for (int i = 0; i < DT.Rows.Count; i++)
            {
                if (Convert.ToInt32(DT.Rows[i]["DNI"]) == jugadores.DNI)
                {
                    DT.Rows[i]["NOMBRE"] = jugadores.NOMBRE;
                    DT.Rows[i]["EQUIPO"] = jugadores.EQUIPO;
                    DT.Rows[i]["TARJETAS"] = jugadores.TARJETAS;
                    DT.Rows[i]["DIAS DE SUSPENSO"] = jugadores.DIASSUSPENCION;
                }
            }

            DT.WriteXml("ListaSuspendidos.xml");
        }

        public void Comprobar(Jugadores jugadores) { 
            comprobar = true;

            for (int i = 0; i < DT.Rows.Count; i++)
            {
                if (Convert.ToInt32(DT.Rows[i]["DNI"]) == jugadores.DNI)
                {
                    comprobar = false;
                }
                
            }
        
        }

    }
}
