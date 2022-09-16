class Program
{
    static void Main(string[] args)
    {
        
    }
}

interface IMessage
{
    void Send();
    string Text { get; set;}
    string Subject { get; set;}
    string ToAddress { get; set; }
    string FromAddress { get; set; }
    byte[] Voice { get; set; }
}

class EmailMessage : IMessage
{
    public string Subject { get; set; } = "";
    public string Text { get; set; } = "";
    public string FromAddress { get; set; } = "";
    public byte[] Voice { get; set; }
    public string ToAddress { get; set; } = "";
    public void Send() => Console.WriteLine($"Отправляем Email-сообщение: {Text}");
}

class SmsMessage : IMessage
{
    public string Text { get; set; } = "";
    public string FromAddress { get; set; } = "";
    public byte[] Voice { get; set; }
    public string ToAddress { get; set; } = "";
    public string Subject
    {
        get
        {
            throw new NotImplementedException();
        }
        set
        {
            throw new NotImplementedException();
        }
    }
    public void Send() => Console.WriteLine($"Отправляем Sms-сообщение: {Text}");
}

class VoiceMessage : IMessage
{
    public string ToAddress { get; set; } = "";
    public string FromAddress { get; set; } = "";
    public byte[] Voice { get; set; } = new byte[] {};
    public string Text
    {
        get
        {
            throw new NotImplementedException();
        }
        set
        {
            throw new NotImplementedException();
        }
    }
    public string Subject
    {
        get
        {
            throw new NotImplementedException();
        }
        set
        {
            throw new NotImplementedException();
        }
    }
    public void Send() => Console.WriteLine("Передача голосовой почты");
}

interface IMessage1
{
    void Send();
    string ToAddress { get; set; }
    string FromAddress { get; set; }
}
interface IVoiceMessage : IMessage1
{
    byte[] Voice { get; set; }
}
interface ITextMessage : IMessage1
{
    string Text { get; set; }
}
interface IEmailMessage : ITextMessage
{
    string Subject { get; set; }
}
class VoiceMessage1 : IVoiceMessage
{
    public string ToAddress { get; set; } = "";
    public string FromAddress { get; set; } = "";
    public byte[] Voice { get; set; } = Array.Empty<byte>(); 
    public void Send() => Console.WriteLine("Передача голосовой почты");
}
class EmailMessage1 : IEmailMessage
{
    public string Text { get; set; } = "";
    public string Subject { get; set; } = "";
    public string FromAddress { get; set; } = "";
    public string ToAddress { get; set; } = "";
    public void Send() => Console.WriteLine("Отправляем по Email сообщение: {Text}");
}
class SmsMessage1 : ITextMessage
{
    public string Text { get; set; } = "";
    public string FromAddress { get; set; } = "";
    public string ToAddress { get; set; } = "";
    public void Send() => Console.WriteLine("Отправляем по Sms сообщение: {Text}");
}