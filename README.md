# Документация по приложению deeplay-test

# 1. Настройка базы данных

Нужно запустить docker-compose.yml по адресу ...\deeplay-test\deeplay-test\deeplay-test\docker-compose.yml

# 2. Работа с приложением
Файл запуска хранится по адресу ...\deeplay-test\deeplay-test\deeplay-test\bin\Debug\net6.0-windows\deeplay-test.exe

2.1 Начальное окно "Управление персоналом":

![image](https://user-images.githubusercontent.com/81422717/172888019-7497c151-2aae-46c4-9644-0f8b660e9d9f.png)

Рабочее пространство:

![image](https://user-images.githubusercontent.com/81422717/172888110-bb7a52f6-b813-4a21-ae17-4c1d8ba7494c.png)

При подключенной базе данных там отображаются сотрудники, соответствующие фильтру


Фильтр состоит из двух составляющих - Должность и Подразделение

"Отбор по должности" устанавливает фильтр на должность отображаемых сотрудников:

![image](https://user-images.githubusercontent.com/81422717/172888175-844b9a41-7dbf-46f6-b274-5c7ce5fc1524.png)

"Отбор по подразделению" устанавливает фильтр на подразделение отображаемых сотрудников:

![image](https://user-images.githubusercontent.com/81422717/172888223-06916b16-c96c-4847-abda-02107edeb060.png)

**Так как в ТЗ подразделение, как уникальная информация, есть только у Руководителей подразделений, то, при действующем фильтре на подразделения, отображаются только они**

![image](https://user-images.githubusercontent.com/81422717/172889993-d5e205ef-e204-41c0-abda-5eacf608bbfa.png)


Кнопка "Отбор" производит отбор сотрудников из базы данных по фильтру:

![image](https://user-images.githubusercontent.com/81422717/172888273-56a3733a-93f2-43c9-a292-de51f0066709.png)

Кнопка "Удалить" сотрудника удаляет выбранного сотрудника из базы данных:

![image](https://user-images.githubusercontent.com/81422717/172888314-b5df663c-3178-4a62-bfd8-5bb017f5b84e.png)

Кнопка "Добавить" сотрудника открывает незаполненное окно "Редактор профиля сотрудника":

![image](https://user-images.githubusercontent.com/81422717/172888816-dbae5946-019c-408d-b02d-50e69992b3fa.png)

Само окно:

![image](https://user-images.githubusercontent.com/81422717/172888780-5cdb7d5a-eb2e-4e21-8fd7-47abe5127f1b.png)

Кнопка "Редактировать" также открывает "Редактор профиля сотрудника", но уже заполненный существующей информацией:

![image](https://user-images.githubusercontent.com/81422717/172889156-4caa02c4-fbcf-4c9a-b354-791420f0f96b.png)

![image](https://user-images.githubusercontent.com/81422717/172889300-23bffd2d-e2f2-41e6-acfa-0aff46321088.png)

2.2 Окно "Редактор профиля сотрудника":

![image](https://user-images.githubusercontent.com/81422717/172889746-054a7942-d7a3-4e9c-919f-ea6c25a3ccc6.png)

Кнопка "Сгенерировать" - генерирует новый уникальный ID:

![image](https://user-images.githubusercontent.com/81422717/172890272-531e3b92-28a7-4b9f-98b4-2545741282b3.png)

![image](https://user-images.githubusercontent.com/81422717/172890423-839b6037-b7d7-460c-a1c1-4813c09aa300.png)

Три поля под ФИО:

![image](https://user-images.githubusercontent.com/81422717/172890673-8f86c52c-ed20-44a5-a37a-0cc310f0778d.png)

Выбор даты рождения:

![image](https://user-images.githubusercontent.com/81422717/172890772-36e022a6-f33d-4b36-abde-f6433f83525c.png)

Выбор пола:

![image](https://user-images.githubusercontent.com/81422717/172890894-15e1f679-d137-458d-aa28-277320854c93.png)

Выбор должности:

![image](https://user-images.githubusercontent.com/81422717/172890954-890e70d4-1157-4291-be24-cf123d846cd5.png)

И выбор уникальной информации, взависимости от должности:

![image](https://user-images.githubusercontent.com/81422717/172891123-6e2763f8-b9a6-4979-b97f-5bf1a35f26fb.png)

У директоров это приставка к названию

![image](https://user-images.githubusercontent.com/81422717/172891156-a4e25d2c-66f3-4955-b56a-7edbe8a6b5b1.png)

У руководителей подразделений - список подразделений

![image](https://user-images.githubusercontent.com/81422717/172891183-88f83904-21e5-4f7e-b51b-0b28968a269a.png)

У контролеров - список руководителей подразделений

![image](https://user-images.githubusercontent.com/81422717/172891219-3b10a877-0d17-4ec7-be08-51a73770fba4.png)

А у рабочих - список контролеров

Кнопка подтвердить добавляет сотрудника в базу или обновляет его данные
Неактивна до тех пор, пока все поля не заполнены

![image](https://user-images.githubusercontent.com/81422717/172891913-cc69d9d9-825f-47ac-b157-d7c8d09c548f.png)
![image](https://user-images.githubusercontent.com/81422717/172891952-ed673276-a6cf-4d6a-8b99-d1c092502bd0.png)

При попытке добавить нового сотрудника с уже неуникальным ID выпвдет ошибка, предупреждающая об этом

![image](https://user-images.githubusercontent.com/81422717/172892221-6cf5d63b-7a13-45a9-829a-89f73e23f201.png)
