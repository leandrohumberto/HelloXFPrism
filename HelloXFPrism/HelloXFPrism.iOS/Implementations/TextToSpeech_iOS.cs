using AVFoundation;

[assembly: Xamarin.Forms.Dependency(typeof(HelloXFPrism.iOS.Implementations.TextToSpeech_iOS))]
namespace HelloXFPrism.iOS.Implementations
{
    class TextToSpeech_iOS : Dependencies.ITextToSpeech
    {
        public void Speak(string text)
        {
            var speechSynthesizer = new AVSpeechSynthesizer();

            var speechUtterance = new AVSpeechUtterance(text)
            {
                Rate = AVSpeechUtterance.MaximumSpeechRate / 4,
                Voice = AVSpeechSynthesisVoice.FromLanguage("en-US"),
                Volume = 0.5f,
                PitchMultiplier = 1.0f
            };

            speechSynthesizer.SpeakUtterance(speechUtterance);
        }

    }
}