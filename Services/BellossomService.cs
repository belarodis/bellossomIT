using System.Collections.Generic;
using System.Linq;
using bellossomIT.Models;

namespace bellossomIT.Services
{
    public class BellossomService
    {
        private readonly List<FlowerModel> _flowers = new List<FlowerModel>();
        private readonly List<VaseModel> _vases = new List<VaseModel>();
        private readonly List<FertilizerModel> _fertilizers = new List<FertilizerModel>();

        //FLOWERS
        public void AddFlower(FlowerModel flower)
        {
            _flowers.Add(flower);
        }

        public void RemoveFlower(FlowerModel flower)
        {
            _flowers.Remove(flower);
        }

        public void UpdateFlower(FlowerModel flower)
        {
            var existing = _flowers.FirstOrDefault(f => f.Id == flower.Id);
            if (existing != null)
            {
                _flowers.Remove(existing);
                _flowers.Add(flower);
            }
        }

        public IEnumerable<FlowerModel> ListFlowers()
        {
            return _flowers;
        }


        //VASES
        public void AddVase(VaseModel vase)
        {
            _vases.Add(vase);
        }

        public void RemoveVase(VaseModel vase)
        {
            _vases.Remove(vase);
        }

        public void UpdateVase(VaseModel vase)
        {
            var existing = _vases.FirstOrDefault(v => v.Id == vase.Id);
            if (existing != null)
            {
                _vases.Remove(existing);
                _vases.Add(vase);
            }
        }

        public IEnumerable<VaseModel> ListVases()
        {
            return _vases;
        }


        //FERTILIZERS
        public void AddFertilizer(FertilizerModel fertilizer)
        {
            _fertilizers.Add(fertilizer);
        }

        public void RemoveFertilizer(FertilizerModel fertilizer)
        {
            _fertilizers.Remove(fertilizer);
        }

        public void UpdateFertilizer(FertilizerModel fertilizer)
        {
            var existing = _fertilizers.FirstOrDefault(f => f.Id == fertilizer.Id);
            if (existing != null)
            {
                _fertilizers.Remove(existing);
                _fertilizers.Add(fertilizer);
            }
        }

        public IEnumerable<FertilizerModel> ListFertilizers()
        {
            return _fertilizers;
        }
    }
}
