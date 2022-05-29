using System.Threading.Tasks;
using HomeApi.Data.Models;

namespace HomeApi.Data.Repos
{
    /// <summary>
    /// Интерфейс определяет методы для доступа к объектам типа Room в базе 
    /// </summary>
    public interface IRoomRepository
    {
        /// <summary>
        /// Выгрузить все комнаты
        /// </summary>
        Task<Room[]> GetRooms();
        /// <summary>
        ///  Найти комнату по имени
        /// </summary>
        Task<Room> GetRoomByName(string name);

        /// <summary>
        ///  Добавить новую комнату
        /// </summary>
        Task AddRoom(Room room);        
    }
}