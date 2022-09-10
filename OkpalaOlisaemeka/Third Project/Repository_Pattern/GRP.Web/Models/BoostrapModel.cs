using GRP.Web.Code;

namespace GRP.Web.Models
{
    public class BoostrapModel
    {
        public string ID { get; set; }
        public string AreaLabelId { get; set; }
        public ModalSize Size { get; set; }
        public string Message { get; set; }
        public string ModalSizeClass
        {
            get
            {
                switch (this.Size)
                {
                    case ModalSize.Small:
                        return "modal-sm";
                    case ModalSize.Medium:
                        return "modal-lg";
                    case ModalSize.Large:
                    default:
                        return "";
                }
            }
        }
    }
}
