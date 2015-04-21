using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;

namespace CodedUIExtensionsAndHelpers.PageModeling
{
    public abstract class HtmlCancellablePageModelBase<TUIType, TUICancelClickElement, TNextModel> : HtmlHasNextModelPageModelBase<TUIType, TNextModel>, ICancellablePageModel<TNextModel>
        where TNextModel : IPageModel
        where TUIType : HtmlControl
        where TUICancelClickElement : HtmlControl
    {
        protected HtmlCancellablePageModelBase(BrowserWindow bw, TNextModel nextModel) : base(bw, nextModel)
        {
        }

        abstract protected TUICancelClickElement ClickToCancelElement { get; }

        public IClickablePageModel<TNextModel> CancelModel
        {
            get { return this.ClickToCancelElement.AsClickablePageModel(this.NextModel1); }
        } 

        public TNextModel Cancel()
        {
            return this.CancelModel.Click();
        }
    }
}