namespace ReactNative.Bridge
{
    interface IGenericDelegate
    {
        object Invoke(object[] args);

        object DelegateTarget { get; }
    }
}
