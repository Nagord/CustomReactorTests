using ContentMod.Components.Extractor;

namespace CustomContentTests.Extractor
{
    class DragonExtractor : ExtractorPlugin
    {
        public override string Name => "Dragon Extractor";

        public override float Stability => 5f;
    }
}
