# CalcularNota.cs
// En c#   crea un programa que se deba tener en cuenta la nota de
prácticas para realizar la media, siendo ambas exactas.
El resultado será una nota numérica que puede tener decimales, además tanto en las
prácticas como en los exámenes solo se podrán evaluar con tres notas (4, 7, 10).
Con todo esto y las siguientes valoraciones, calcula la nota numérica final:
Si la nota del examen es 4, la nota será la misma que la del examen independientemente
de la de las prácticas.
Si la nota del examen es 7 y la de prácticas es mayor o igual a 7 la nota será la media
entre ambas
Si la nota del examen es 7 y la de prácticas es 4 la nota final será 5
Si la nota del examen es 10 y la de prácticas menor o igual a 7 la nota final será 9
Si la nota del examen es 10 y la de prácticas es 10, la nota final será 11
Se indicará nota incorrecta en caso de introducir una nota no permitida y podemos usar una
ternaria y la variable notaFinal nullable.
Nota: Para hacer este ejercicio deberás usar la expresión switch de C#8 con tuplas.
