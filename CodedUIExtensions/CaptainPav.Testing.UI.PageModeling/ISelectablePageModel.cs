namespace CaptainPav.Testing.UI.PageModeling
{
    /// <summary>
    /// Interface for page model which can be considered seleted or not
    /// </summary>
    /// <typeparam name="TNextModel">
    /// The most likely page model with which the user will interact after
    /// setting the selection state of this page model.  This is typically
    /// the containing page model.
    /// </typeparam>
    public interface ISelectablePageModel<out TNextModel> : IValueablePageModel<bool, TNextModel> where TNextModel : IPageModel
    {
        /// <summary>
        /// Gets whether this page model is in the selected state
        /// </summary>
        bool IsSelected { get; }

        /// <summary>
        /// Sets the selection state of this page model, if possible
        /// </summary>
        /// <param name="selectionState">
        /// The desired selection state of this page model
        /// </param>
        /// <returns>
        /// The most likely page model with which the user will interact
        /// after attempting to set the selection state of this page model.
        /// 
        /// This is typically the containing page model.
        /// </returns>
        TNextModel SetSelected(bool selectionState);
    }
}