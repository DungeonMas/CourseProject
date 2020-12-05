using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyEnigma
{
    public class Rotor
    {
		public string alphabet; // алфавит ротора
		public byte offset; // смещение
		public Label rotLabel; // метка, на которой отображается текущая позиция ротора
		public Rotor previousPosition, nextPosition; // предыдущая/следующая позиция ротора
		public char inputData = '\0'; // входная информация
		public char notchPosition; // позиция ротора, при которой происходит переключение следующего ротора

		// Конструктор
		public Rotor(string alphabet, Label rotLabel, char notchPosition)
		{
			this.alphabet = alphabet;
			this.rotLabel = rotLabel;
			this.notchPosition = notchPosition;
			offset = 0;
		}

		// Установить следующую позицию ротора
		public void SetNextRotor(Rotor nextPosition)
		{
			this.nextPosition = nextPosition;
		}

		// Установить предыдущую позицию ротора
		public void SetPreviousRotor(Rotor previousPosition)
		{
			this.previousPosition = previousPosition;
		}

		// Получить значение текущего смещения
		public int GetOffset()
		{
			return offset;
		}

		// Получить значение позиции ротора, при которой происходит переключение следующего ротора
		public char GetNotchPos()
		{
			return notchPosition;
		}

		// сбросить смещение до начального значения
		public void ResetOffset()
		{
			offset = 0;
		}

		// Проверка на наличие следующей позиции в роторе
		public bool HasNext()
		{
			if (nextPosition != null)
				return true;
			else
				return false;
		}

		// Проверка на наличие предыдущей позиции в роторе
		public bool HasPrevious()
		{
			if (previousPosition != null)
				return true;
			else
				return false;
		}

		// переключение ротора на позицию вперед
		public void Switch()
		{
			// если следующей позиции нет то выходим отсюда
			if (nextPosition == null)
			{
				return;
			}

			offset++;
			// Если это буква Z, то обнуляем смещение 
			if (offset == 26)
			{
				ResetOffset();
			}

			if (HasNext() && (offset + 66) == ((notchPosition - 64) % 26) + 66)
			{
				nextPosition.Switch();
			}

			rotLabel.Text = "" + ((char)(65 + offset));
		}

		// переключение ротора на позицию назад
		public void SwitchBack()
		{
			if (offset == 0)
			{
				offset = 26;
			}

			offset--;

			rotLabel.Text = "" + ((char)(65 + offset));
		}

		// Обработчик, принимающий данные и шифрующий их согласно смещению
		public void PutDataIn(char text)
		{
			inputData = text;
			char charArray = text;
			charArray = (char)(((charArray - 65) + offset) % 26 + 65);

			if (HasNext())
			{
				charArray = alphabet.Substring((charArray - 65), 1).ToCharArray()[0];

				if ((((charArray - 65) + (-offset)) % 26 + 65) >= 65)
				{
					charArray = (char)(((charArray - 65) + (-offset)) % 26 + 65);
				}
				else
				{
					charArray = (char)(((charArray - 65) + (26 + (-offset))) % 26 + 65);
				}

				nextPosition.PutDataIn(charArray);

			}
		}

		public char GetInverseCharAt(string ch)
		{
			int pos = alphabet.IndexOf(ch);

			if (offset > pos)
			{
				pos = 26 - (offset - pos);
			}
			else
			{
				pos -= offset;
			}

			if (HasPrevious())
			{
				pos = (pos + previousPosition.GetOffset()) % 26;
			}

			return (char)(65 + pos);
		}

		public char GetDataOut()
		{
			char charArray = '\0';

			if (HasNext())
			{
				charArray = nextPosition.GetDataOut();
				charArray = GetInverseCharAt("" + charArray);
			}
			else
			{ 
				charArray = alphabet.Substring((inputData - 65), 1).ToCharArray()[0];
				charArray = (char)(((charArray - 65) + previousPosition.offset) % 26 + 65);

			}

			return charArray;
		}		
	}
}
