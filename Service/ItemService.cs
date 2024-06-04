using Model;
using Repository;

namespace Service
{
    public class ItemService
    {
        private readonly IItemRepository _itemRepository;

        public ItemService() => _itemRepository = new ItemRepository();

        public int Insert(Item item) => _itemRepository.Insert(item);
    }
}
