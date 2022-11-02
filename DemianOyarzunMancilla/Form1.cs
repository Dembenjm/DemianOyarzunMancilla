namespace DemianOyarzunMancilla
{
    public partial class Form1 : Form
    {
        private Atencion[] atenciones = new Atencion[100];
        private int cantidad = 0;
        public Form1()
        {
            InitializeComponent();
        }
        public void salir()
        {
            Application.Exit();
        }
        public void limpiar()
        {
            txtRut.Clear();
            txtNombre.Clear();
            txtCelular.Clear();
            txtEmail.Clear();
            txtNombreExistente.Clear();
            txtCelularExistente.Clear();
            txtEmailExistente.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            salir();
        }

        private void btnSalir2_Click(object sender, EventArgs e)
        {
            salir();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private Cliente buscarCliente(string rut)
        {
            Cliente c;
            for (int i = 0; i < cantidad; i++)
            {
                c = atenciones[i].ClienteAtencion;
                if (c.Rut.Equals(rut))
                    return c;
            }
            return null;
        }
        private void enlazarAtencionCliente(Atencion a, Cliente c)
        {
            a.ClienteAtencion = c;
            c[c.Cantidad] = a;
            //p.Cantidad++;
        }
        private void mostrar(Atencion a, Cliente c)
        {
            string nuevo = "Atencion: " + " Fecha: " + a.Fecha + " Hora: " + a.Hora + " Tipo de atención: " + a.TipoAtencion
                + " Nombre Cliente: " + c.Nombre + " Rut: " + c.Rut + " Celular: " + c.Celular + " Email: " + c.Email;
            lstReservas.Items.Add(nuevo);
            MessageBox.Show("Reserva ingresada");
            limpiar();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (cboHora.Text != "HORA:" && chkBarba.Checked || chkCabello.Checked)
            {
                Atencion a = new Atencion();
                a.TipoAtencion = chkBarba.Text + ", " + chkCabello.Text;
                a.Hora = cboHora.Text;
                a.Fecha = calendarioDate.SelectionStart.Day.ToString() + "/" + calendarioDate.SelectionStart.Month.ToString() + "/" + calendarioDate.SelectionStart.Year.ToString();

                if (txtNombre.Text != "" && txtRut.Text != "" && txtCelular.Text != "")
                {
                    Cliente c = new Cliente();
                    c.Rut = txtRut.Text;
                    c.Nombre = txtNombre.Text;
                    c.Celular = txtCelular.Text;
                    c.Email = txtEmail.Text;

                    enlazarAtencionCliente(a, c);
                    mostrar(a, c);

                    cboRutExistente.Items.Add(c.Rut);

                    atenciones[cantidad] = a;
                    cantidad++;
                }

                else if (cboRutExistente.SelectedItem != null)
                {
                    Cliente c = buscarCliente(cboRutExistente.Text);
                    enlazarAtencionCliente(a, c);
                    mostrar(a, c);

                    atenciones[cantidad] = a;
                    cantidad++;
                }

                else
                {
                    MessageBox.Show("Debe seleccionar un cliente existente o ingresar uno nuevo");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar el tipo de atención una fecha y una hora");
            }
        }

            private void btnBuscar_Click(object sender, EventArgs e)
            {
                if(cboRutExistente.SelectedItem != null)
                {
                    Cliente c;
                    c = buscarCliente(cboRutExistente.Text);
                    if(c != null)
                    {
                        txtNombreExistente.Text = c.Nombre;
                        txtCelularExistente.Text = c.Celular;
                        txtEmailExistente.Text = c.Email;
                    }
                }
            }
        }
    }