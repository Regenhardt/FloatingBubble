namespace FloatingBubble.Interfaces
{
    /// <summary>
    /// Interface with main reason to preserve the MVVM pattern --> buisness logic not knowing about views
    /// Interface making sure that one can hide, how and close a window
    /// </summary>
    interface IHideShowAndCloseable
    {
        void Close();

        void Hide();

        void Show();
    }
}
