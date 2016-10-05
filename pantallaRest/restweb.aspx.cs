using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Text;

namespace pantallaRest
{
    public partial class restweb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string url = string.Format("http://localhost:8084/api/empleado");
            WebClient respuesta = new WebClient();
            string response = respuesta.DownloadString(new Uri(url));
            List<emple> lstEmp = JsonConvert.DeserializeObject<List<emple>>(response);
            GridView1.DataSource = lstEmp;
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string url = string.Format("http://localhost:8084/api/empleado/{0}", TextBox1.Text);
            WebClient respuesta = new WebClient();
            string response = respuesta.DownloadString(new Uri(url));
            emple tx = JsonConvert.DeserializeObject<emple>(response);
            List<emple> lstTaxa = new List<emple>();
            lstTaxa.Add(tx);
            GridView1.DataSource = lstTaxa;
            GridView1.DataBind();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            emple empleInsertado = new emple();
            empleInsertado.idEmpleado = TextBox2.Text;
            empleInsertado.nombre = TextBox3.Text;
            

            string url = String.Format("http://localhost:8084/api/empleado/");
            string method = "POST";
            WebClient client = new WebClient();
            string jsonObj = JsonConvert.SerializeObject(empleInsertado);
            ASCIIEncoding encoding = new ASCIIEncoding();
            Byte[] bytes = encoding.GetBytes(jsonObj);
            client.Headers.Add("Content-Type", "application/json");
            client.UploadData(url, method, bytes);
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            emple empleModificado = new emple();
            empleModificado.idEmpleado = TextBox2.Text;
            empleModificado.nombre = TextBox3.Text;

            string url = String.Format("http://localhost:8084/api/empleado/{0}", TextBox2.Text);
            string method = "PUT";
            WebClient client = new WebClient();
            string jsonObj = JsonConvert.SerializeObject(empleModificado);
            ASCIIEncoding encoding = new ASCIIEncoding();
            Byte[] bytes = encoding.GetBytes(jsonObj);
            client.Headers.Add("Content-Type", "application/json");
            client.UploadData(url, method, bytes);
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            string url = String.Format("http://localhost:8084/api/empleado/{0}", TextBox2.Text);
            string method = "DELETE";
            WebClient client = new WebClient();
            client.Headers.Add("Content-Type", "application/json");
            string repry = client.UploadString(url, method, "");
        }
    }
}