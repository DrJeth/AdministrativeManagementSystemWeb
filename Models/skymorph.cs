namespace AdministrativeManagementSystemWeb.Models
{
    public class skymorph
    {
        public double center_dec { get; set; }
        public double center_ra { get; set; }
        public string key { get; set; }
        public double mag { get; set; }
        public string obs_id { get; set; }
        public double offset { get; set; }
        public double pixel_loc_x { get; set; }
        public double pixel_loc_y { get; set; }
        public double pos_err_ang { get; set; }
        public double pos_err_major { get; set; }
        public double pos_err_minor { get; set; }
        public double predicted_dec { get; set; }
        public double predicted_ra { get; set; }
        public DateTime time { get; set; }
        public string triplet { get; set; }
        public double veloc_sn { get; set; }
        public double veloc_we { get; set; }
    }
    public class SkymorphResponse
    {
        public List<skymorph> Results { get; set; }
    }
}
