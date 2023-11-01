using System.Data.SqlClient;
using System.Data;
using Certamen.Models;

namespace Certamen.Datos
{
    public class Participantedatos
    {
        public List<Participantes> Listar()
        {
            var oLista = new List<Participantes>();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();

                SqlCommand cmd = new SqlCommand("sp_Listar", conexion);
                    
                    cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader()) 
                {
                    while (dr.Read()) {
                        oLista.Add(new Participantes()
                        {
                            Idmodelo = Convert.ToInt32(dr["Idmodelo"]),
                            Nombre = dr["Nombre"].ToString(),
                            Apellidos = dr["Apellidos"].ToString(),
                            Edad = Convert.ToInt32(dr["Edad"]),
                           
                            Fecha = Convert.ToDateTime(dr["Fecha"]),
                            Altura = Convert.ToInt32(dr["Altura"]),
                            Telefono = dr["Telefono"].ToString(),
                            Correo = dr["Correo"].ToString(),
                            Nacionalidad = dr["Nacionalidad"].ToString(),
                            FormacionAcademica = dr["FormacionAcademica"].ToString(),


                        }); ;


                    
                    }
                }
            }

            return oLista;
        }



        public Participantes Obtener(int Idmodel)
        {
            var oParticipante = new Participantes();

            var cn = new Conexion();

            using (var conexion = new SqlConnection(cn.getCadenaSQL()))
            {
                conexion.Open();

                SqlCommand cmd = new SqlCommand("sp_Obtener", conexion);
                cmd.Parameters.AddWithValue("Idmodel", Idmodel);
                    
                    cmd.CommandType = CommandType.StoredProcedure;

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        
                        {
                            oParticipante.Idmodelo = Convert.ToInt32(dr["Idmodelo"]);
                            oParticipante.Nombre = dr["Nombre"].ToString();
                            oParticipante.Apellidos = dr["Apellidos"].ToString();
                            oParticipante.Edad = Convert.ToInt32(dr["Edad"]);
                            oParticipante.FechaNac = Convert.ToDateTi(dr["FechaNac"]);
                            oParticipante.Fecha = Convert.ToDateTime(dr["Fecha"]);
                            oParticipante.Altura = Convert.ToInt32(dr["Altura"]);
                            oParticipante.Telefono = dr["Telefono"].ToString();
                            oParticipante.Correo = dr["Correo"].ToString();
                            oParticipante.Nacionalidad = dr["Nacionalidad"].ToString();
                            oParticipante.FormacionAcademica = dr["FormacionAcademica"].ToString();


                        }; 



                    }
                }
            }

            return oParticipante;
        }

        public bool Guardar(Participantes oparticipantes)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();

                    SqlCommand cmd = new SqlCommand("sp_Guardar", conexion);

                    cmd.Parameters.AddWithValue("Nombre", oparticipantes.Nombre);
                    cmd.Parameters.AddWithValue("Apellidos", oparticipantes.Apellidos);
                    cmd.Parameters.AddWithValue("Apellidos", oparticipantes.Edad);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();

                }
                rpta = true;
            }
            catch (Exception e) { 
             string error = e.Message; 
             rpta = false; }

        }



        public bool Editar(Participantes oparticipantes)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();

                    SqlCommand cmd = new SqlCommand("sp_Editar", conexion);

                    cmd.Parameters.AddWithValue("Idmodelo", oparticipantes.Idmodelo);
                    cmd.Parameters.AddWithValue("Nombre", oparticipantes.Nombre);
                    cmd.Parameters.AddWithValue("Apellidos", oparticipantes.Apellidos);
                    cmd.Parameters.AddWithValue("Apellidos", oparticipantes.Edad);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();

                }
                rpta = true;
            }
            catch (Exception e)
            {
                string error = e.Message;
                rpta = false;
            }

        }


        public bool Eliminar(int Idmodelo)
        {
            bool rpta;

            try
            {
                var cn = new Conexion();

                using (var conexion = new SqlConnection(cn.getCadenaSQL()))
                {
                    conexion.Open();

                    SqlCommand cmd = new SqlCommand("sp_Eliminar", conexion);

                    cmd.Parameters.AddWithValue("Idmodelo", Idmodelo);
                   

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.ExecuteNonQuery();

                }
                rpta = true;
            }
            catch (Exception e)
            {
                string error = e.Message;
                rpta = false;
            }

        }

    }
}
