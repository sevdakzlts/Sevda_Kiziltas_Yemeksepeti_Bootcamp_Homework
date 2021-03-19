using System;
using System.Collections.Generic;
using InventoryApp.Model;
using System.Collections.ObjectModel;
using System.IO;
using Newtonsoft.Json;

namespace InventoryApp.Data
{
    public class InventoryData : IDatabase
    {
        public ObservableCollection<InventoryItem> InventoryItems { get; set; }

        public InventoryData()
        {
            var jsonData = File.ReadAllText("InventoryItem.json");
            var data = JsonConvert.DeserializeObject<List<InventoryItem>>(jsonData);
            this.InventoryItems = new ObservableCollection<InventoryItem>(data ?? new List<InventoryItem>());
            this.InventoryItems.CollectionChanged += InventoryItems_Collectionhenged;
        }

        private void InventoryItems_Collectionhenged(object sender,
            System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
            {
                
            }

            if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
            {
                
            }
        }

    }

    public interface IDatabase
    {
        ObservableCollection<InventoryItem> InventoryItems { get; set; }
    }
}
