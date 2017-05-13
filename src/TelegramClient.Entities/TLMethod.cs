
namespace TelegramClient.Entities
{
    public abstract class TlMethod : TlObject
    {
        public virtual bool Confirmed { get; } = true;
    }

    public abstract class TlMethod<TResult> : TlMethod 
    {
    }
}