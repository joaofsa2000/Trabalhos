#include "Data.h"

#pragma warning(disable : 4996) //_CRT_SECURE_NO_WARNINGS

time_t t = time(NULL);
tm* timePtr = localtime(&t);

Data::Data()
{
	dia = 1; mes = 1; ano = 2000;
}

Data::Data(int dia, int mes, int ano)
{
	if (mes <= timePtr->tm_mon+1 && ano > 1900 && ano <= 1900 + timePtr->tm_year) {
		if (ano == timePtr->tm_year + 1900 && mes == timePtr->tm_mon+1 && dia > timePtr->tm_mday) {
			this->dia = 1;
			this->mes = 1;
			this->ano = 2000;
		}
		else {
			if (mes > 0 && mes < 13) {
				if (ano % 4 == 0 && (ano % 400 == 0 || ano % 100 != 0)) {
					if (mes == 2) {
						if (dia > 0 && dia < 30) {
							this->dia = dia;
							this->mes = mes;
							this->ano = ano;
						}
						else {
							this->dia = 1;
							this->mes = 1;
							this->ano = 2000;
						}
					}
					else {
						if (mes <= 7) {
							if (mes % 2 == 0) {
								if (dia > 0 && dia < 31) {
									this->dia = dia;
									this->mes = mes;
									this->ano = ano;
								}
								else {
									this->dia = 1;
									this->mes = 1;
									this->ano = 2000;
								}
							}
							else {
								if (dia > 0 && dia < 32) {
									this->dia = dia;
									this->mes = mes;
									this->ano = ano;
								}
								else {
									this->dia = 1;
									this->mes = 1;
									this->ano = 2000;
								}
							}
						}
						else {
							if (mes % 2 == 0) {
								if (dia > 0 && dia < 32) {
									this->dia = dia;
									this->mes = mes;
									this->ano = ano;
								}
								else {
									this->dia = 1;
									this->mes = 1;
									this->ano = 2000;
								}
							}
							else {
								if (dia > 0 && dia < 31) {
									this->dia = dia;
									this->mes = mes;
									this->ano = ano;
								}
								else {
									this->dia = 1;
									this->mes = 1;
									this->ano = 2000;
								}
							}
						}
					}
				}
				else {
					if (mes == 2) {
						if (dia > 0 && dia < 29) {
							this->dia = dia;
							this->mes = mes;
							this->ano = ano;
						}
						else {
							this->dia = 1;
							this->mes = 1;
							this->ano = 2000;
						}
					}
					else {
						if (mes <= 7) {
							if (mes % 2 == 0) {
								if (dia > 0 && dia < 31) {
									this->dia = dia;
									this->mes = mes;
									this->ano = ano;
								}
								else {
									this->dia = 1;
									this->mes = 1;
									this->ano = 2000;
								}
							}
							else {
								if (dia > 0 && dia < 32) {
									this->dia = dia;
									this->mes = mes;
									this->ano = ano;
								}
								else {
									this->dia = 1;
									this->mes = 1;
									this->ano = 2000;
								}
							}
						}
						else {
							if (mes % 2 == 0) {
								if (dia > 0 && dia < 32) {
									this->dia = dia;
									this->mes = mes;
									this->ano = ano;
								}
								else {
									this->dia = 1;
									this->mes = 1;
									this->ano = 2000;
								}
							}
							else {
								if (dia > 0 && dia < 31) {
									this->dia = dia;
									this->mes = mes;
									this->ano = ano;
								}
								else {
									this->dia = 1;
									this->mes = 1;
									this->ano = 2000;
								}
							}
						}
					}
				}
			}
			else {
				this->dia = 1;
				this->mes = 1;
				this->ano = 2000;
			}
		}
	}
	else {
		this->dia = 1;
		this->mes = 1;
		this->ano = 2000;
	}
}

Data::Data(const Data &d) {
	dia = d.dia;
	mes = d.mes;
	ano = d.ano;
}

bool Data::setDia(int dia) {
	if (mes <= timePtr->tm_mon+1 && ano > 1900 && ano <= 1900 + timePtr->tm_year) {
		if (ano == (timePtr->tm_year+1900) && mes == timePtr->tm_mon+1 && dia > timePtr->tm_mday) {
			return 0;
		}
		else {
			if ((ano - 2000) % 4 == 0 && (ano % 400 == 0 || ano % 100 != 0)) {
				if (mes == 2) {
					if (dia > 0 && dia < 30) {
						this->dia = dia;
						return 1;
					}
					else {
						return 0;
					}
				}
				else {
					if (mes <= 7) {
						if (mes % 2 == 0) {
							if (dia > 0 && dia < 31) {
								this->dia = dia;
								return 1;
							}
							else {
								return 0;
							}
						}
						else {
							if (dia > 0 && dia < 32) {
								this->dia = dia;
								return 1;
							}
							else {
								return 0;
							}
						}

					}
					else {
						if (mes % 2 == 0) {
							if (dia > 0 && dia < 32) {
								this->dia = dia;
								return 1;
							}
							else {
								return 0;
							}
						}
						else {
							if (dia > 0 && dia < 31) {
								this->dia = dia;
								return 1;
							}
							else {
								return 0;
							}
						}
					}
				}
			}
			else {
				if (mes == 2) {
					if (dia > 0 && dia < 29) {
						this->dia = dia;
						return 1;
					}
					else {
						return 0;
					}
				}
				else {
					if (mes <= 7) {
						if (mes % 2 == 0) {
							if (dia > 0 && dia < 31) {
								this->dia = dia;
								return 1;
							}
							else {
								return 0;
							}
						}
						else {
							if (dia > 0 && dia < 32) {
								this->dia = dia;
								return 1;
							}
							else {
								return 0;
							}
						}

					}
					else {
						if (mes % 2 == 0) {
							if (dia > 0 && dia < 32) {
								this->dia = dia;
								return 1;
							}
							else {
								return 0;
							}
						}
						else {
							if (dia > 0 && dia < 31) {
								this->dia = dia;
								return 1;
							}
							else {
								return 0;
							}
						}
					}
				}
			}
		}
	}
	else
		return 0;
}

bool Data::setMes(int mes) { 
	if (mes <= timePtr->tm_mon + 1 && ano > 1900 && ano <= 1900 + timePtr->tm_year) {
		if (ano == (timePtr->tm_year + 1900) && mes == timePtr->tm_mon + 1 && dia > timePtr->tm_mday) {
			return 0;
		}
		else {
			if ((ano - 2000) % 4 == 0 && (ano % 400 == 0 || ano % 100 != 0)) {
				if (mes == 2) {
					if (dia > 0 && dia < 30) {
						this->mes = mes;
						return 1;
					}
					else {
						return 0;
					}
				}
				else {
					if (mes <= 7) {
						if (mes % 2 == 0) {
							if (dia > 0 && dia < 31) {
								this->mes = mes;
								return 1;
							}
							else {
								return 0;
							}
						}
						else {
							if (dia > 0 && dia < 32) {
								this->mes = mes;
								return 1;
							}
							else {
								return 0;
							}
						}

					}
					else {
						if (mes % 2 == 0) {
							if (dia > 0 && dia < 32) {
								this->mes = mes;
								return 1;
							}
							else {
								return 0;
							}
						}
						else {
							if (dia > 0 && dia < 31) {
								this->mes = mes;
								return 1;
							}
							else {
								return 0;
							}
						}
					}
				}
			}
			else {
				if (mes == 2) {
					if (dia > 0 && dia < 29) {
						this->mes = mes;
						return 1;
					}
					else {
						return 0;
					}
				}
				else {
					if (mes <= 7) {
						if (mes % 2 == 0) {
							if (dia > 0 && dia < 31) {
								this->mes = mes;
								return 1;
							}
							else {
								return 0;
							}
						}
						else {
							if (dia > 0 && dia < 32) {
								this->mes = mes;
								return 1;
							}
							else {
								return 0;
							}
						}

					}
					else {
						if (mes % 2 == 0) {
							if (dia > 0 && dia < 32) {
								this->mes = mes;
								return 1;
							}
							else {
								return 0;
							}
						}
						else {
							if (dia > 0 && dia < 31) {
								this->mes = mes;
								return 1;
							}
							else {
								return 0;
							}
						}
					}
				}
			}
		}
	}
	else
		return 0;
}

bool Data::setAno(int ano) {
	if (ano > 1900 && ano <= 1900 + timePtr->tm_year) {
		if (mes == 2) {
			if ((ano - 2000) % 4 == 0 && (ano % 400 == 0 || ano % 100 != 0)) {
				if (dia < 30) {
					this->ano = ano;
					return 1;
				}
				else {
					return 0;
				}
			}
			else {
				if (dia < 29) {
					this->ano = ano;
					return 1;
				}
				else {
					return 0;
				}
			}
		}
		else {
			this->ano = ano;
			return 1;
		}
	}
	else {
		return 0;
	}
	
}

std::string Data::toString()
{
	return "\n\n" + to_string(dia) + "/" + to_string(mes)+"/" + to_string(ano)+"\n";
}
