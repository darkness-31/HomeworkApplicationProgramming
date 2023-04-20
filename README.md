# Домашнаяя работа по прикладному программированию

Язык программирование: С#
IDE: Visual Studio 2022 :purple_heart:
Платформа: Windows
Интерфейс приложений: WinForms

## 1 задание - **Калькулятор**
Компоненты которые нужны:
  - TextBox
  - Button:
    - \+
    - \-
    - /
    - \*
    - =
    - C (Отчиска экрана)
    - \- (Отрицательное число)
    - , (запятая дробное число)
> ### Описание
> Сделать возможность после первого подсчета (нажатия =), если нажать на : +;-;/;* то продолжать расчет (предыдущий ответ взять за 1-ое число), а если нажать на цифру то очистить экран, для ввода 1-ого числа.

## 2 задание - **Расписание**
Компоненты которые нужны:
- 2x TextBox
- Button:
  - Открыть
  - Составление
>  ### Описание
>  нужно разобрать текст сделать проверку суммы занятий (не больше 25) и рандомно составить расписание в формате 5 дней по 5 занятий и вывести его во 2-ой текст бокс, данные из 1 текст бокса открытые в кнопке открытие); Сохранение (сохраняет в тхт файл в проводнике содержимое 2го текст бокса);
>  > Пример:
>  > - Математика 4
>  > 
>  > - Русский язык 4
>  > 
>  > - Физика 2
>  > 
>  > - и т.п.

## 3 задание - **Гороскопы**
Компоненты которые нужны:
- TextBox
- Button
>  ### Описание
>  В текст бокс мы вводим дату рождения, а при нажатии на кнопку из БД (лучше всего SQLite) выводим знак зодиака и информацию про него.

## 4 задание - **JSON в БД**
Компоненты которые нужны:
- Button
>  ### Описание
>  При нажатии кнопки открывает тхт файл в проводнике и разбираем его с помощью json и записываем в БД (можно так же в SQLite).

Содержимое тхт файла:
``` json
[{"1.8.0*kWh":0.001,"3.8.0*kVARh":0.000,"4.8.0*kVARh":0.000,"17.8.0*kVARh":0.000,"18.8.0*kVARh":0.000,"0.9.4":"2020-09-09T21:00:00+00:00","0.2.0":"3.1.66919fc0f50864cae2c5df64ed741218f12bcfd71c","0.2.1":"1.1.30","C.1.6":"7CEC710274B33EEEC17EAC714F024CA3D8308DBB","C.1.7":"053D6F2FCABDDC4B2B38CC10DF2389EBF04E0FFE","9.9.9":11984},{"1.8.0*kWh":0.001,"3.8.0*kVARh":0.000,"4.8.0*kVARh":0.000,"17.8.0*kVARh":0.000,"18.8.0*kVARh":0.000,"0.9.4":"2020-09-10T21:00:00+00:00","0.2.0":"3.1.66919fc0f50864cae2c5df64ed741218f12bcfd71c","0.2.1":"1.1.30","C.1.6":"7CEC710274B33EEEC17EAC714F024CA3D8308DBB","C.1.7":"053D6F2FCABDDC4B2B38CC10DF2389EBF04E0FFE","9.9.9":12008},{"1.8.0*kWh":0.001,"3.8.0*kVARh":0.000,"4.8.0*kVARh":0.000,"17.8.0*kVARh":0.000,"18.8.0*kVARh":0.000,"0.9.4":"2020-09-11T21:00:00+00:00","0.2.0":"3.1.66919fc0f50864cae2c5df64ed741218f12bcfd71c","0.2.1":"1.1.30","C.1.6":"7CEC710274B33EEEC17EAC714F024CA3D8308DBB","C.1.7":"053D6F2FCABDDC4B2B38CC10DF2389EBF04E0FFE","9.9.9":12032}]
```

## 5 задание - **Сравнение текста** 
Компоненты которые нужны:
- 2x TextBox
- Buttons: 
  - Открытие (открывает тхт файл в проводнике и выводит его в 1й текст бокс)
  - Открытие (открывает тхт файл в проводнике и выводит его в 2й текст бокс)
  - Проверка (сравнивает тексты из 2х текст боксов, и выводит совпадают или нет, если нет то чем отличаются)
>  ### Описание
>  Проверка должна учитывать добавление или удаление слова в тексте.

## 6 задание - **Записная книжка с БД SQLite**
Компоненты которые нужны:
- TextBox
- 2x DateTimePicker
- Button:
  - Добавить (данные из текст бокса и 1 календаря записывает в БД)
  - Отобразить (показывает данные за выбранный интервал времени в текст боксе, списком) 
>  ### Описание
>  Дата в БД хранится в формате Unix-время по гринвичу, в отдельном столбце хранить часовой пояс.

## 7 задание - **Программа тестирования знаний**
Компоненты которые нужны:
- DataGridView
- Button:
  - Начать тест
  - Отобразить
>  ### Описание
>  Из БД SQLite выводятся вопросы в таблицу (5-10), пользователь заносит ответы в пустые ячейки напротив каждого вопроса; при нажатии кнопки проверить, система делает слияние 2х листов (правильные ответы в бд) и выводит результат правильных ответов (не правильные ответы выводятся пустыми).

## 8 задание - **Программа для создания/редактирования XML документов**
Компоненты которые нужны:
- DataGridView
- Button:
  - Сохранить (формируем информацию из датагрида и сериализируем в xml документ)
  - Открыть (десериализируем из xml документа и отображаем в датагриде)
>  ### Описание
>  В датагриде сделать удобную прокрутку, структура датагрида/xml документа свободная, но обязательно использовать типы: string, DateTime, int/double, bool; количество записей 5-10.

## 9 задание - **Программа для просмотра/создания/редактирования таблиц**
Компоненты которые нужны:
- DataGridView
- GroupBox (выбора dll для сохранения, открытия)
- Button:
  - Сохранить
  - Открыть
>  ### Описание
>  Минимум 2 dll подключенных к программе.
