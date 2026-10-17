namespace Demo_09
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.Write("Въведете първото цяло число: ");
                int firstNumber = int.Parse(Console.ReadLine() ?? string.Empty);

                Console.Write("Въведете второто цяло число: ");
                int secondNumber = int.Parse(Console.ReadLine() ?? string.Empty);

                // При целочислено деление на нула се хвърля DivideByZeroException.
                int result = firstNumber / secondNumber;
                Console.WriteLine($"Резултат от целочисленото деление: {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Грешка: въведете валидно цяло число.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Грешка: не може да се дели на нула.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Грешка: числото или резултатът е извън диапазона на int.");
            }
            finally
            {
                // Изпълнява се и при успех, и при обработено изключение.
                Console.WriteLine("Край на опита за изчисление.");
            }
        }
    }
}
