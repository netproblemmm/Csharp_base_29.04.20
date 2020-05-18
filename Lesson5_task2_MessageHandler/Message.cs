using System.Linq;
using System.Text;

public class Message
{
    // Удаление из строки mess слов более, чем длина limit
    public static string SymbolsLimit(string mess, int limit)
    {
        string _newMess = ""; // переделанная строка - результат обработки
        string[] _stringMassive; // массив, возвращаемый после обработки SplitStringIntoMassive
        _stringMassive = mess.Replace(",", "").Split(' '); // чистка строки от пунктуации и разбиение на отдельные слова

        for (int i = 0; i < _stringMassive.Length; i++)
        {
            if (_stringMassive[i].Length <= limit)
                _newMess += _stringMassive[i] + " ";
        }
        return _newMess;
    }

    // Удаление из строки mess слов, которые оканчиваются на букву letter
    public static string DeleteWordsWithLastLetter(string mess, string letter)
    {
        string _newMess = "";
        string[] _stringMassive;
        string _letter = "";
        _stringMassive = mess.Replace(",", "").Split(' ');

        for (int i = 0; i < _stringMassive.Length; i++)
        {
            _letter = _stringMassive[i].Last().ToString();
            if (_letter.Equals(letter) == false)
                _newMess += _stringMassive[i] + " ";
        }
        return _newMess;
    }

    // Нахождение самого длинного слова сообщения mess
    public static string MostLongWord(string mess)
    {
        string[] _stringMassive;
        int _mostLength = 0;
        string _mostLongWord = "";
        _stringMassive = mess.Replace(",", "").Split(' ');

        for (int i = 0; i < _stringMassive.Length; i++)
        {
            if (_stringMassive[i].Length >= _mostLength)
            {
                _mostLength = _stringMassive[i].Length;
                _mostLongWord = _stringMassive[i].ToString();
            }
        }
        return _mostLongWord;
    }

    // Нахождение 2 самых длинных слов во фразе mess, используя StringBuilder
    public static string MostLongWordsStringBuilder(string mess)
    {
        string[] _stringMassive;
        int _mostLength1 = 0;
        int _mostLength2 = 0;
        string _mostLongWord1 = "";
        string _mostLongWord2 = "";
        _stringMassive = mess.Replace(",", "").Split(' ');

        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < _stringMassive.Length; i++)
        {
            if (_stringMassive[i].Length >= _mostLength1)
            {
                if (_mostLength1 > 0)
                {
                    _mostLength2 = _mostLength1;
                    _mostLongWord2 = _mostLongWord1;
                }
                _mostLength1 = _stringMassive[i].Length;
                _mostLongWord1 = _stringMassive[i].ToString();
            }
        }
        sb.Append(_mostLongWord1);
        sb.Append(" ");
        sb.Append(_mostLongWord2);
        return sb.ToString();
    }
}
