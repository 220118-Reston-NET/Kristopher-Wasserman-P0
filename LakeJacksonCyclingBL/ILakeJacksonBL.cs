using LakeJacksonCyclingModel;


namespace LakeJacksonCyclingBL
{
    /// <summary>
    /// This Data layer is used to make things happen. 
    /// </summary>
    public interface LakeJacksonBL
    {
        /// <summary>
        /// Function below will add inventory to the stores application. 
        /// </summary>
        /// <param name="p_inv"></param>
        /// <returns></returns>
        ItemsLines AddInventory(ItemsLines p_inv);
    }
}


