
Algoritmo calc_v4
	
		Definir select como entero;
		Definir v2 ,v1 ,resulsuma , resulresta ,resuldiv ,resulmul como real;
		Definir repeat como caracter;
		
	Repetir	
		Escribir "seleccione el primer valor";
		Leer v1;
		Escribir "Seleccione el segundo valor";
		Leer v2;
		
		Escribir "seleccione entre 1-4 ";
		Escribir "[1]SUMA";
		Escribir "[2]RESTA";
		Escribir "[3]DIVISION";
		Escribir "[4]MULTIPLICACION";
		leer select;
		
		
		Mientras select<1 o select>4 Hacer
			Escribir "[ERROR]:";
			Escribir "seleccione entre 1-4 ";
			Escribir "[1]SUMA";
			Escribir "[2]RESTA";
			Escribir "[3]DIVISION";
			Escribir "[4]MULTIPLICACION";
			Leer select;
		FinMientras
		
		Segun select Hacer
			1:
				Escribir "Has seleccionado sumar los valores " ,v1 ," y " ,v2 ," :"; 
				resulsuma <- v1+v2;
				Escribir "El Resultado es: " ,resulsuma;
			2:
				Escribir "Has seleccionado restar los valores " ,v1 ," y " ,v2 ," :"; 
				resulresta <- v1-v2;
				Escribir "El Resultado es: " ,resulresta;
			3:
				Si v2=0 Entonces
					Escribir "[ERROR] No puedes dividir entre 0";
				SiNo
					Escribir "Has seleccionado dividir los valores " ,v1 ," y " ,v2 ," :"; 
					resuldiv <- v1/v2;
					Escribir "El Resultado es: " ,resuldiv;
				FinSi
			4:	
				Escribir "Has seleccionado multiplicar los valores " ,v1 ," y " ,v2 ," :"; 
				resulmul <- v1*v2;
				Escribir "El Resultado es: " ,resulmul;
			De Otro Modo:
				Escribir "";
		FinSegun
		Escribir "¿Quieres volver a repetir el proceso?";
		Leer repeat;
		
		Mientras repeat<> "s" y repeat<>"n" Hacer
			Escribir "[ERROR] Diga s/n";
			Leer repeat;
		FinMientras
		
	Hasta Que repeat="n";
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
FinAlgoritmo 
