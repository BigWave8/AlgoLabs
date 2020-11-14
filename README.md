# Govern problem

### Write on C# language

Для закордонної поїздки вам потрiбно отримати кiлька довiдок вiд держустанови.
Проте, виявилося, що для отримання цих довiдок потрiбнi iншi довiдки, а тi, в свою
чергу, потребують ще iнших довiдок.
На отримання кожної довiдки потрiбно вистояти чергу, тому ви хочете зекономити
час, не стоячи в черзi дарма (якщо ви не будете мати потрiбних довiдок, стоячи в
черзi, вам вiдмовлять у видачi цiєї).
Маючи iнформацiю про те, якi довiдки потрiбнi для яких, визначте оптимальний
порядок отримання усiх довiдок, при якому вам жодного разу не вiдмовлять у
видачi. Якщо таких оптимальних варiантiв кiлька — виведiть будь-який iз них.

Вхiднi данi
Кожен iз N рядкiв вхiдного файлу govern .in мiстить два слова, роздiленi пробiлом
— назва довiдки та довiдка, яку потрiбно отримати перед нею.
• Рядкiв може бути вiд 1 до 100000.
• Слова мають довжину вiд 1 до 50 лiтер i складаються з цифр 0-9 i малих лiтер
латинського алфавiту вiд a до z.
• Якщо для однiєї довiдки потрiбно отримати N iнших, файл мiститиме N рядкiв,
що починатимуться на одне й те саме слово.
• Гарантовано iснує хоча б один порядок отримання довiдок, при якому можна
отримати усi довiдки.

Вихiднi данi
Вихiдний файл govern .out повинен мiстити M рядкiв — назви довiдок в порядку їх
рекомендованого отримання.

## Instruction :

The algorithm will work.
The answer will be displayed in the specified file.
Then the console will display the inscription that the data is already in the file.
Otherwise, if there is incorrect data in the reader file, an error message will be displayed.

## Algorithm :

To begin, the algorithm reads the data.
Every first word takes the key, and the second the value.
If you need to write the value again, it is overridden.
Also, if there is no right number on the left (otherwise there will be a loop, which will lead to an error), it will be written as a key with an empty value.
Next, documents that do not have non-essential documents are taken in order, after which they are marked as received, and then this is repeated for the documents for which they were necessary.
This continues until all documents are received.
During this algorithm, all values are written and output to a file.