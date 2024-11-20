using System;

using System.Windows.Forms;
using System.Data.SqlClient;

namespace Prueba2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conexion = new SqlConnection("Server=LAPTOP-L9PPJL8J;Database=Banco;integrated security=True;");
        private void btn_Crear_Click(object sender, EventArgs e)
        {

            string query = "INSERT INTO Clientes (CI, Nombre, Apellido, Contrasena) VALUES (@CI, @Nombre, @Apellido, @Contrasena)";

            using (SqlCommand command = new SqlCommand(query, conexion))
            {
                
                command.Parameters.AddWithValue("@CI", txt_Ci.Text);
                command.Parameters.AddWithValue("@Nombre", txt_Nombre.Text);
                command.Parameters.AddWithValue("@Apellido", txt_Apellido.Text);
                command.Parameters.AddWithValue("@Contrasena", txt_Contraseña.Text);

                try
                {
                    command.ExecuteNonQuery();

                    MessageBox.Show("Cliente creado exitosamente.");


                    txt_Ci.Clear();
                    txt_Nombre.Clear();
                    txt_Apellido.Clear();
                    txt_Contraseña.Clear();
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error al crear cliente: {ex.Message}");
                }
            }
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Id.Text))
            {
                MessageBox.Show("Debe buscar un cliente primero.");
                return;
            }

            string query = "UPDATE Clientes SET Nombre = @Nombre, Apellido = @Apellido, Contrasena = @Contrasena WHERE id_cliente = @ID";

            using (SqlCommand command = new SqlCommand(query, conexion))
            {
                command.Parameters.AddWithValue("@ID", txt_Id.Text);
                command.Parameters.AddWithValue("@Nombre", txt_Nombre.Text);
                command.Parameters.AddWithValue("@Apellido", txt_Apellido.Text);
                command.Parameters.AddWithValue("@Contrasena", txt_Contraseña.Text);

                try
                {
                   
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Datos actualizados correctamente.");
                        txt_Id.Clear();
                        txt_Ci.Clear();
                        txt_Nombre.Clear();
                        txt_Apellido.Clear();
                        txt_Contraseña.Clear();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el cliente. Verifique el ID.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar cliente: {ex.Message}");
                }
                
            }
        }

        private void btn_Leer_Click(object sender, EventArgs e)
        {

        }

        private void btn_Borrar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txt_Id.Text))
            {
                MessageBox.Show("Debe buscar un cliente primero o ingresar un ID válido.");
                return;
            }

            DialogResult confirmacion = MessageBox.Show(
                "¿Está seguro de que desea eliminar este cliente? Esta acción no se puede deshacer.",
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirmacion == DialogResult.Yes)
            {
                string query = "DELETE FROM Clientes WHERE id_cliente = @ID";

                using (SqlCommand command = new SqlCommand(query, conexion))
                {
                    command.Parameters.AddWithValue("@ID", txt_Id.Text);

                    try
                    {
                        conexion.Open();

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cliente eliminado correctamente.");

                            
                            txt_Id.Clear();
                            txt_Ci.Clear();
                            txt_Nombre.Clear();
                            txt_Apellido.Clear();
                            txt_Contraseña.Clear();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el cliente con el ID proporcionado.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al eliminar cliente: {ex.Message}");
                    }
                    
                }
            }
        }

        private void btn_Conectar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                MessageBox.Show("Conexion con la base de datos correcta");
            }
            catch (Exception conect)
            {
                MessageBox.Show("Conexion fallida" + conect);
            }
        }

        private void btn_Desconectar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.Close();
                MessageBox.Show("Se ha desconectado de la base de datos correctamenta");
            }
            catch (Exception x)
            {
                MessageBox.Show("No se pudo desconectar " + x);
            }
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {

            string ci = Microsoft.VisualBasic.Interaction.InputBox(
                "Ingrese el CI del cliente que desea actualizar:",
                "Actualizar Cliente",
                ""
            );

            if (string.IsNullOrWhiteSpace(ci))
            {
                MessageBox.Show("Debe ingresar un CI válido.");
                return;
            }

            string query = "SELECT Id_Cliente,CI, Nombre, Apellido, Contrasena FROM Clientes WHERE CI = @CI";

            using (SqlCommand command = new SqlCommand(query, conexion))
            {
                command.Parameters.AddWithValue("@CI", ci);

                try
                {

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            txt_Ci.Text = reader["CI"].ToString();
                            txt_Nombre.Text = reader["Nombre"].ToString();
                            txt_Apellido.Text = reader["Apellido"].ToString();
                            txt_Contraseña.Text = reader["Contrasena"].ToString();
                            txt_Id.Text = reader["Id_Cliente"].ToString();

                            MessageBox.Show("Datos cargados correctamente. Puede proceder a editar.");
                        }
                        else
                        {
                            MessageBox.Show("Cliente no encontrado.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al buscar cliente: {ex.Message}");
                }
            }
        }
    }
}
