using MagicVilla_Simple_.NET_API_project.Models.Dto;

namespace MagicVilla_Simple_.NET_API_project.Data
{
    public class VillaStore
    {
        public static List<VillaDTO> villaList = new List<VillaDTO>()
            {
                new VillaDTO {Id =1, Name = "Thilanka", Occupancy=4, Sqft=120},
                new VillaDTO {Id =2,Name="River Side", Occupancy=3, Sqft = 100}
            };
    }
}
