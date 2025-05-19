using FinalProject_PSD_EmpatSekawan.Handler;
using FinalProject_PSD_EmpatSekawan.Model;
using System.Collections.Generic;

namespace FinalProject_PSD_EmpatSekawan.Controller
{
    public class JewelController
    {
        private JewelHandler jewelHandler = new JewelHandler();

        public List<MsJewel> GetAllJewels()
        {
            return jewelHandler.GetAllJewels();
        }

        public MsJewel GetJewelById(int id)
        {
            return jewelHandler.GetJewelById(id);
        }

        public void AddJewel(MsJewel jewel)
        {
            jewelHandler.AddJewel(jewel);
        }
    }
}
