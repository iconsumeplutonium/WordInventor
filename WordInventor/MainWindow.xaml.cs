using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WordInventor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() {
            InitializeComponent();
            Activities();
        }

        public int wordLength;
        //[HideInInspector]
        public List<int> wordInIndexes = new List<int>();

        public bool autoUpdate;
        private Random prng = new Random();

        private NumericUpDown numericUpDown1 = new NumericUpDown();

        //private void Start() {
        //    Activities();
        //}

        public void CreateWord() {
            WordDictionary w = new WordDictionary();
            int index;
            for (int i = 0; i < wordLength; i++) {
                if (i == 0) {
                    index = prng.Next(0, WordList.words.Length - 1);
                    w = WordList.words[index];
                }

                wordInIndexes.Add(w.index);
                index = prng.Next(0, w.followingSounds.Count - 1);
                w = WordList.words[w.followingSounds[index]];

            }
        }

        public string ConvertIndexWordToString(List<int> word) {
            string w = "";
            for (int i = 0; i < word.Count; i++) {
                if (i == 0) {
                    char[] sound = WordList.words[word[i]].sound.ToCharArray();
                    w += (sound.Length == 2) ? sound[0].ToString().ToUpper() + sound[1].ToString() : sound[0].ToString().ToUpper();

                }
                else
                    w += WordList.words[word[i]].sound;
            }
            return w;
        }

        public void Activities() {
            //wordLength = (bool)UseRandomLengthCheck.IsChecked ? prng.Next(3, 7) : 7;
            //CurrentWordLengthTest.Content = "Word Length: " + wordLength;
            wordLength = int.Parse(WLBox.Text);
            WordTextBox.Text = "";
            wordInIndexes.Clear();
            CreateWord();
            WordTextBox.Text = ConvertIndexWordToString(wordInIndexes);
        }

        private void OnGenerateButtonClick(object sender, RoutedEventArgs e) {
            Activities();
        }

        private void OnIncrease(object sender, RoutedEventArgs e) {
            int value = Math.Min(18, int.Parse(WLBox.Text) + 1);
            WLBox.Text = value.ToString();
        }

        private void OnDecrease(object sender, RoutedEventArgs e) {
            int value = Math.Max(2, int.Parse(WLBox.Text) - 1);
            WLBox.Text = value.ToString();
        }

        private void OnRandom(object sender, RoutedEventArgs e) {
            WLBox.Text = prng.Next(2, 18).ToString();
        }







    }

    
    public static class WordList {
        public static WordDictionary[] words = new WordDictionary[] {
        new WordDictionary(0, "a", new List<int> {1, 2, 3, 5, 6, 7, 8, 9, 10, 11, 12, 13, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29}),
        new WordDictionary(1, "b", new List<int> {0, 4, 7, 8, 11, 14, 17, 20, 24}),
        new WordDictionary(2, "c", new List<int> {0, 4, 7, 8, 10, 11, 14, 17, 20}),
        new WordDictionary(3, "d", new List<int> {0, 4, 7, 8, 14, 17, 20, 22}),
        new WordDictionary(4, "e", new List<int> {0, 1, 2, 3, 5, 6, 7, 8, 9, 10, 11, 12, 13, 15, 16, 17, 18, 19, 21, 22, 23, 24, 25, 26, 27, 28, 29}),
        new WordDictionary(5, "f", new List<int> {0, 4, 7, 8, 11, 14, 17, 20}),
        new WordDictionary(6, "g", new List<int> {0, 4, 7, 8, 11, 13, 14, 18, 19, 20, 24}),
        new WordDictionary(7, "h", new List<int> {0, 4, 8, 14, 20, 24}),
        new WordDictionary(8, "i", new List<int> {0, 1, 2, 3, 5, 6, 7, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 21, 22, 23, 24, 25, 26, 27, 28, 29}),
        new WordDictionary(9, "j", new List<int> {0, 4, 7, 8, 11, 14, 17, 20}),
        new WordDictionary(10, "k", new List<int> {0, 4, 7, 8, 11, 13, 14, 17, 20, 24}),
        new WordDictionary(11, "l", new List<int> {0, 4, 7, 8, 14, 20}),
        new WordDictionary(12, "m", new List<int> {0, 4, 7, 8, 14, 20}),
        new WordDictionary(13, "n", new List<int> {0, 3, 4, 6, 7, 8, 14, 18, 19}),
        new WordDictionary(14, "o", new List<int> {0, 1, 2, 3, 5, 6, 7, 8, 9, 10, 11, 12, 13, 15, 16, 17, 18, 19, 21, 22, 23, 24, 25, 26, 27, 28, 29}),
        new WordDictionary(15, "p", new List<int> {0, 4, 7, 8, 11, 13, 14, 17, 18, 20, 24}),
        new WordDictionary(16, "q", new List<int> {0, 4, 8, 14, 17, 20}),
        new WordDictionary(17, "r", new List<int> {0, 4, 7, 8, 12, 13, 14, 19, 20, 24, 26, 27, 28, 29}),
        new WordDictionary(18, "s", new List<int> {0, 4, 7, 8, 10, 11, 12, 13, 14, 16, 17, 19, 20, 22, 23}),
        new WordDictionary(19, "t", new List<int> {0, 4, 7, 8, 14, 17, 18, 20, 22, 24, 27}),
        new WordDictionary(20, "u", new List<int> {1, 2, 3, 5, 6, 7, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 21, 22, 23, 24, 25}),
        new WordDictionary(21, "v", new List<int> {0, 4, 7, 8, 11, 14, 20}),
        new WordDictionary(22, "w", new List<int> {0, 4, 7, 8, 14, 17, 20}),
        new WordDictionary(23, "x", new List<int> {0, 2, 3, 8, 15, 19}),
        new WordDictionary(24, "y", new List<int> {0, 1, 2, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 17, 18, 19, 20, 21, 22, 24}),
        new WordDictionary(25, "z", new List<int> {0, 4, 8}),
        new WordDictionary(26, "sh", new List<int> {0, 4, 8, 11, 12, 14, 17, 19, 20}),
        new WordDictionary(27, "ch", new List<int> {0, 4, 8, 11, 12, 14, 17, 20, 24}),
        new WordDictionary(28, "th", new List<int> {0, 4, 8, 11, 14, 17, 20, 24}),
        new WordDictionary(29, "ph", new List<int> {0, 4, 8, 11, 14, 17, 20}),
        };
    }

    public struct WordDictionary {

        public int index;
        public string sound;
        public List<int> followingSounds;

        public WordDictionary(int index, string s, List<int> i) {
            this.index = index;
            sound = s;
            followingSounds = i;
        }

    }
}
