Algoritmo meses_del_years
		Escribir "Digite un numero Del 1-12 Para mostrar los meses del years"
		Leer num
		
		Mientras num <= 0 o num >=13 Hacer
			Escribir "[ERROR]: MES NO VALIDO: Los meses son del [1-12]"
			Leer num
		Fin Mientras
		
		Si num = 1  Entonces
			Escribir "Enero"
		SiNo
			Si nume = 2 Entonces
				Escribir "Febrero"
			FinSi
			si num =3 Entonces
				Escribir "Marzo"
			FinSi
			si num =4 Entonces
				Escribir "Abril"
			FinSi
			si num =5 Entonces
				Escribir "Mayo"
			FinSi
			si num =6 Entonces
				Escribir "Junio"
			FinSi
			si num = 7 Entonces
				Escribir "Julio"
			FinSi
			si num = 8 Entonces
				Escribir "Agosto"
			FinSi
			si num = 9 Entonces
				Escribir "Septiembre"
			FinSi
			si num = 10 Entonces
				Escribir "Octubre"
			FinSi
			si num = 11 Entonces
				Escribir "Noviembre"
			FinSi
			si num = 12 Entonces
				Escribir "Diciembre"
			FinSi
			si num >=13 o num <=0 Entonces
				Escribir "Esto no es un mes"
			FinSi
		FinSi	
		
		
FinAlgoritmo

