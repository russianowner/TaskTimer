# TaskTimer
---
- Простое приложение на WinForms для создания задач с напоминаниями
---
- A simple WinForms application for creating tasks with reminders
---

## О приложении:
- Добавление, удаление и отметка задач
- Уведомления в трее Windows
- (опционально) Отправка напоминаний в Telegram

---

## About the app:
- Adding, deleting and marking tasks
- Notifications in the Windows tray
- (optional) Sending reminders to Telegram

---

## NuGet Packages:
- Newtonsoft.Json
- Telegram.Bot

---

## Как запустить:
1. Склонируйте репозиторий
2. Откройте проект в Visual Studio 2022 или в другом совместимом IDE
3. Восстановите NuGet пакеты
---
4. Если вам не нужен телеграм уведомления от бота, то:
- Удали из папки Services файл TelegramService.cs
- Зайди в Form1.cs (правой кнопки мыши, открыть код) и удали все упоминания о CheckTelegam 
- Зайди в Form1.Designer.cs и удали эту строку "TelegramService.Init("токенбота", 234324234);"
---
5. Если вам нужен телеграм бот, то:
- Создай бота через @BotFather в Telegram и получи токен
- Замени "токенбота" в Form1.Designer.cs на токен твоего бота
- Замени 234324234 на твой Telegram user ID (можно узнать через бота @username_to_id_bot)
---
6. После всех изменений, запускаем проект, пишем задачу, выставляем время и проверяем.
---

---

## How to launch:
1. Clone the repository
2. Open the project in Visual Studio 2022 or in another compatible IDE
3. Restore NuGet packages
---
4. If you do not need telegram notifications from the bot, then:
- Delete the Telegram Service.cs file from the Services folder
- Go to Form1.cs (right-click, open the code) and delete all mentions of CheckTelegam 
- Go to Form1.Designer.cs and delete this line "TelegramService.Init(tokenbota, 234324234);"
---
5. If you need a telegram bot, then:
- Create a bot via @BotFather in Telegram and get a token
- Replace the "tokenbot" in Form1.Designer.cs with your bot's token
- Replace 234324234 with your Telegram user ID (you can find out through the bot @username_to_id_bot)
---
6. After all the changes, we launch the project, write the task, set the time and check.
---

---

## Архитектура:
1. Forms/Form1.cs + Form1.Designer.cs:
-  Form1.cs - автомат сгенерированный код, отвечающий за интерфейс и логику взаимодействия с пользователем
-  Form1.Designer.cs - файл, содержащий код для инициализации компонентов формы
---
2. Models/TaskItem.cs:
- Модель которую можно легко сериализовать в JSON или передавать между сервисами
---
3. Services:
- TaskStorage.cs - отвечает за сохранение и загрузку задач + использует JSON для сериализации списка TaskItem
- NotificationService.cs - показывает системное уведомление в трее Windows через NotifyIcon
- TelegramService.cs - отправляет сообщения в Telegram через Telegram.Bot AP
---
4. Program.cs — точка входа
---

---
## Architecture:
1. Forms/Form1.cs + Form1.Designer.cs:
- Form1.cs is an automaton generated code responsible for the interface and logic of user interaction
- Form1.Designer.cs file containing code for initializing form components
---
2. Models/TaskItem.cs:
- A model that can be easily serialized in JSON or transferred between services
---
3. Services:
- TaskStorage.cs - responsible for saving and loading tasks + uses JSON to serialize the TaskItem list
- NotificationService.cs - shows the system notification in the Windows tray via NotifyIcon
- TelegramService.cs - sends messages to Telegram via Telegram.Bot AP
---
4. Program.cs — entry point
---

---
- Данный проект можно развивать дальше, он очень простой, понятный и удобный
---
- This project can be developed further, it is very simple, clear and convenient
---
