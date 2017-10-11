using Android.Speech.Tts;
using HelloXFPrism.Dependencies;
using System.Collections.Generic;
using Xamarin.Forms;

[assembly: Dependency(typeof(HelloXFPrism.Droid.Implementations.TextToSpeech_Droid))]
namespace HelloXFPrism.Droid.Implementations
{
    public class TextToSpeech_Droid : Java.Lang.Object, ITextToSpeech, TextToSpeech.IOnInitListener
    {
        private TextToSpeech speaker;
        private string toSpeak;

        public void Speak(string text)
        {
            var c = Forms.Context;
            toSpeak = text;
            if (speaker == null)
            {
                speaker = new TextToSpeech(c, this);
            }
            else
            {
                var p = new Dictionary<string, string>();
                speaker.Speak(toSpeak, QueueMode.Flush, p);
                System.Diagnostics.Debug.WriteLine("spoke " + toSpeak);
            }
        }

        #region IOnInitListener implementation

        public void OnInit(OperationResult status)
        {
            if (status.Equals(OperationResult.Success))
            {
                System.Diagnostics.Debug.WriteLine("speaker init");
                var p = new Dictionary<string, string>();
                speaker.Speak(toSpeak, QueueMode.Flush, p);
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("was quiet");
            }
        }

        #endregion
    }
}