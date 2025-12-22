namespace WEB_RESTAURANTE.Helpers
{
    public class ResponseModel
    {
        public ResponseModel(string redirect = null)
        {
            success = true;
            error = string.Empty;
            error2 = string.Empty;
            if (!string.IsNullOrEmpty(redirect))
                this.redirect = redirect;
        }

        public string respuesta { get; set; }
        public bool success { get; set; }
        public string redirect { get; set; }
        public string id { get; set; }
        public string error { get; set; }
        public string error2 { get; set; }
        public string extraValue1 { get; set; }
        public string extraValue2 { get; set; }
    }
}
