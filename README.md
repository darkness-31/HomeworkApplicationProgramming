# Домашнаяя работа по прикладному программированию

Язык программирование: С#
IDE: Visual Studio 2022 :purple_heart:
Платформа: Windows
Интерфейс приложений: WinForms

## 1 задание - **Калькулятор**
Компоненты которые нужны:
  - 1 TextBox
  - Кнопки:
    - \+
    - \-
    - /
    - \*
    - =
    - C (Отчиска экрана)
    - \- (Отрицательное число)
    - , (запятая дробное число)
```mermaid
flowchart TD
  classDef cl1 fill:#ffff88,stroke:#ffff77,stroke-width:2px,color:#000000

  noda1["Первый подсчёт (Нажата кнопка '=')"]
  noda2{{"Нажата ли кнопки '+','-','/','*','=','C'"}}

  subgraph Логика
    noda1 --> noda2
  end
  
  class noda1,noda2 cl1
  ```
