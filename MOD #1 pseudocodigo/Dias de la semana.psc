Algoritmo Dia_de_la_semana
	Escribir "Digite un numero"
	Leer num
	
	Mientras num <= 0 o num >=7 Hacer
		Escribir "[ERROR]: MES NO VALIDO: [1-12]"
		Leer num
	Fin Mientras
	
	Si num = 1  Entonces
		Escribir "Lunes"
	SiNo
		Si nume = 2 Entonces
			Escribir "Martes"
		FinSi
		si num =3 Entonces
			Escribir "Miercoles"
		FinSi
		si num =4 Entonces
			Escribir "Jueves"
		FinSi
		si num =5 Entonces
			Escribir "Viernes"
		FinSi
		si num =6 Entonces
			Escribir "Sabado"
		FinSi
		si num = 7 Entonces
			Escribir "Domingo"
		FinSi
		si num >= 8 o num <=0 Entonces
			Escribir "Este dia no existe"
		FinSi
	FinSi	
	

FinAlgoritmo
