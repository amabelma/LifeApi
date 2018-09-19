using LifeApi.Models;
using LifeApi.Models.Enums;
using LifeApi.Repositories.Interfaces;
using System.Collections.Generic;

namespace LifeApi.Repositories
{
    public class MockLifeApiRepository: IMockLifeApiRepository
    {
        public List<Item> GetItemByKeyword(string keyWord)
        {
            throw new System.NotImplementedException();
        }

        public List<Item> GetItemByName(string name)
        {
            throw new System.NotImplementedException();
        }

        public List<Item> GetItemByTitle(string title)
        {
            throw new System.NotImplementedException();
        }

        private List<Item> _items = new List<Item>()
        {
            new Item(
                "Cooler Master MasterCase Pro 5 Mid-Tower Case with FreeForm Modular System, Window Side Panel, Top Mesh Cover, and Watercooling Bracket",
                "Coolermaster Modular Computer Case",
                1,
                "11182015",
                null,
                136.99,
                Location.Basement,
                "Modular Computer Case, holds two HHD's and two SSD's. Black.",
                new List<string>() {"computer", "case", "modular"} 
            ),
            new Item(
                "Brother HL-3170CDW Digital Color Printer",
                "Laser Printer",
                1,
                "08262018",
                null,
                174.91,
                Location.UpstairsOffice,
                "Laser printer with wireless networking. Duplex. Color printing available. Double side printing available.",
                new List<string>() {"laser", "printer"} 
            ),
            new Item(
                "Executive Office Solutions Portable Adjustable Aluminum Laptop Desk/Stand/Table Vented w/CPU Fans Mouse Pad Side Mount-Notebook-Macbook-Light Weight Ergonomic TV Bed Lap Tray Stand Up/Sitting-Black",
                "Standing Desk",
                1,
                "07282018",
                null,
                39.99,
                Location.Basement,
                "Folding standing des. Adjustable legs. Black.",
                new List<string>() {"standing", "desk", "work", "folding", "laptop"} 
            )
        };
    }
}