
# CryptoExchangeApp

CryptoExchangeApp — это веб-приложение обмена криптовалютами, созданное на ASP.NET Core MVC.

## 🚀 Основные функции
- Регистрация и авторизация пользователей
- Управление кошельками (баланс по BTC, ETH, USDT, XRP, DOGE)
- Создание ордеров на покупку/продажу криптовалют
- Переписка между пользователями (личные сообщения)
- Оставление отзывов и оценок
- Админ-панель для управления пользователями, ордерами и отзывами

## ⚙️ Технологии
- ASP.NET Core MVC 6
- Entity Framework Core
- MS SQL Server
- Razor Pages
- Bootstrap 5 (для фронтенда)

## 🏗️ Установка проекта

1. Клонируйте репозиторий или распакуйте ZIP-архив

2. Настройте строку подключения в `appsettings.json`:

```
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=CryptoExchangeAppDb;Trusted_Connection=True;TrustServerCertificate=True;"
}
```

3. Примените миграции базы данных через Package Manager Console:

```
Add-Migration InitialCreate
Update-Database
```

4. Запустите приложение через Visual Studio или командой:

```
dotnet run
```

## 🔒 Учетные записи
- Обычные пользователи имеют роль `User`
- Администратор имеет роль `Admin` (задается вручную через базу данных)

## 📂 Структура проекта

```
CryptoExchangeApp/
├── Controllers/
├── Models/
├── Views/
├── Data/
├── wwwroot/
├── Program.cs
├── Startup.cs
├── appsettings.json
├── README.md
```

## 📜 Лицензия
Только для учебных и демонстрационных целей.

---

# 📦 План действий для публикации на GitHub и запуска на сервере

## 1. Публикация на GitHub

- Инициализируйте локальный git репозиторий:

```bash
git init
git add .
git commit -m "Initial commit"
```

- Создайте репозиторий на GitHub.

- Добавьте удаленный репозиторий и запушьте проект:

```bash
git remote add origin https://github.com/ВАШ_ПОЛЬЗОВАТЕЛЬ/cryptoexchangeapp.git
git branch -M main
git push -u origin main
```

## 2. Развертывание на бесплатном сервере (например, Railway.app)

- Зарегистрируйтесь на [Railway.app](https://railway.app/).
- Нажмите "New Project" → "Deploy from GitHub Repo".
- Выберите ваш репозиторий CryptoExchangeApp.
- Railway сам подтянет ASP.NET Core и предложит развернуть приложение.

**Или можно использовать Render.com / Azure Free Plan для ASP.NET Core проектов.**

---

**Готово! Теперь ваш CryptoExchangeApp в облаке!**
