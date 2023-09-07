#ifndef INPUTS_H_
#define INPUTS_H_


/** \brief Despliega un menu
 *
 * \return int Retorna un numero entero con la opcion deseada
 *
 */
int menu();

/** \brief Permite escribir un mensaje y pedir un numero decimal
 *
 * \param mensaje[] char Mensaje a mostrar por pantalla
 * \return float Retorna el numero decimal ingresado.
 *
 */
float ingresarFloat(char mensaje[]);

/** \brief Permite escribir un mensaje y pedir un numero entero
 *
 * \param mensaje[] char Mensaje a mostrar por pantalla.
 * \return int Retona el numero entero ingresado.
 *
 */
int ingresarInt(char mensaje[]);

/** \brief Permite escribir un mensaje y pedir una cadena de carateres
 *
 * \param mensaje[] char Mensaje a mostrar por pantalla.
 * \param dato[] char La cadena de caracteres a recibir.
 * \return int Retrona 0 si hubo un error o 1 si se ejecuto con exito.
 *
 */
int ingresarString(char mensaje[], char info[]);

/** \brief pasa a mayuscula la primera letra de un string y detecta espacios
 *
 * \param string[] char el mensaje ingresado
 * \return int devuelve 0 en caso de error, 1 si se ejecuto con exito.
 *
 */
int pasarMayusculaPrimerCaracter(char string[]);
/**
 * @fn int validarMinMax(int, int, int)
 * @brief Valida un numero entero entre rango min y max
 * @param numero int a valadidar
 * @param min int minimo de rango
 * @param max int maximo de rango
 * @return Retorna un 1 si esta dentro del rango o 0 si esta fuera de rango
 */
int validarMinMax(int numero,int min, int max);
/**
 * @fn int validarFloatMinMax(float, int, int)
 * @brief Valida un numero decimal entre rango min y max
 * @param numero float a validar
 * @param min int minimo de rango
 * @param max int minimo de rango
 * @return Retorna un 1 si esta dentro del rango o 0 si esta fuera de rango
 */
int validarFloatMinMax(float numero,int min,int max);

#endif /* INPUTS_H_ */

