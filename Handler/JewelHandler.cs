using FinalProject_PSD_EmpatSekawan.Model;
using FinalProject_PSD_EmpatSekawan.Repository;
using System.Collections.Generic;

namespace FinalProject_PSD_EmpatSekawan.Handler
{
    public class JewelHandler
    {
        private JewelRepository jewelRepository = new JewelRepository();

        public List<MsJewel> GetAllJewels()
        {
            return jewelRepository.All();
        }

        public MsJewel GetJewelById(int id)
        {
            return jewelRepository.GetJewelById(id);
        }

        public void AddJewel(MsJewel jewel)
        {
            jewelRepository.AddJewel(jewel);
        }

        public void UpdateJewel(MsJewel jewel)
        {
            jewelRepository.UpdateJewel(jewel);
        }

        public void DeleteJewel(MsJewel jewel)
        {
            jewelRepository.DeleteJewel(jewel);
        }
    }
}
