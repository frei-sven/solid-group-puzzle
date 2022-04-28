using solid_group_puzzle.good.PresentationLayerServices;

namespace solid_group_puzzle.good.PresentationLayer
{
    public class Presentation
    {
        private IPresentationService _logicA;
        private IPresentationService _logicB;

        public Presentation(IPresentationService logicA, IPresentationService logicB)
        {
            _logicA = logicA;
            _logicB = logicB;
        }

        public void PresentA()
        {
            Console.WriteLine(_logicA.GetLogicDataEnhanced());
        }

        public void PresentB()
        {
            Console.WriteLine(_logicB.GetLogicDataEnhanced());
        }
    }
}
