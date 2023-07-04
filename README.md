# TestTaskWork
**Первая форма** - открывается при запуске программы. Содержит список изображений, полученных по адресу:
https://fakerapi.it/api/v1/images?_quantity=30&_type=any&_height=300
При двойном клике на элемент списка открывается вторая форма в диалоговом режиме, содержащая title, description, url  выбранного изображения и само изображение в PictureBox.

Во вторую форму передается объект, содержащий все данные необходимые для отображения. 
Для связывания данных и элементов формы использована технология DataBinding.
К второй форме добавлен TexBox снизу, чтобы изменять URL изображения.
<p align="center">
<image src=/images/Form1.png>
</p>
<p align="center">
<image src=/images/Form2.png>
</p>
<p align="center">
<image src=/images/ChangeURL.png>
</p>
