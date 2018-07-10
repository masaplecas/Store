using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class BaseAppPage : BasePage
    {
        #region Fields
        public TopMenu TopMenu { get; }
        public FooterMenu FooterMenu { get; }

        #endregion

        #region Ctor
        public BaseAppPage(string relativePath): base(relativePath)

        {
            TopMenu = new TopMenu();
            Driver.InitializeElements(TopMenu);
            FooterMenu = new FooterMenu();
            Driver.InitializeElements(FooterMenu);
        }
        #endregion
    }
}
