using Sce.Atf;

namespace Razix
{
    public static class RZCEResources
    {
        /* Razix logo 32x32 icon */
        [ImageResource("RazixCodeEditorLogo.ico")]
        public static readonly string RazixCodeEditorLogo;

        [ImageResource("RazixAtf.ico")]
        public static readonly string RazixAtf;

        private const string ResourcePath = "Razix.Resources.";

        static RZCEResources()
        {
            ResourceUtil.Register(typeof(Resources), ResourcePath);
        }
    }
}
