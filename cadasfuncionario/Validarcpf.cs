using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text.RegularExpressions;
public static class Validar
{

    public static bool CPF(string cpf)
    {
        cpf = cpf.Replace(".", "");
        cpf = cpf.Replace("-", "");

        if (cpf.Length != 11)
        {
            return false;
        }
        else
        {
            int a = Convert.ToInt32(cpf[0].ToString());
            int b = Convert.ToInt32(cpf[1].ToString());
            int c = Convert.ToInt32(cpf[2].ToString());
            int d = Convert.ToInt32(cpf[3].ToString());
            int e = Convert.ToInt32(cpf[4].ToString());
            int f = Convert.ToInt32(cpf[5].ToString());
            int g = Convert.ToInt32(cpf[6].ToString());
            int h = Convert.ToInt32(cpf[7].ToString());
            int i = Convert.ToInt32(cpf[8].ToString());
            int j = Convert.ToInt32(cpf[9].ToString());
            int k = Convert.ToInt32(cpf[10].ToString());

            int soma1 = (a * 10) + (b * 9) + (c * 8) + (d * 7) + (e * 6) + (f * 5) + (g * 4) + (h * 3) + (i * 2);
            int resto = soma1 % 11;
            int soma2 = (a * 11) + (b * 10) + (c * 9) + (d * 8) + (e * 7) + (f * 6) + (g * 5) + (h * 4) + (i * 3) + (j * 2);
            int resto2 = soma2 % 11;


            if (resto >= 2)
            {
                if ((11 - resto) == j)
                {
                    if (resto2 >= 2)
                    {
                        if ((11 - resto2) == k)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else if (resto2 < 2)
                    {
                        if (resto2 == 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else if (resto < 2)
            {
                if (resto == 0)
                {
                    if (resto2 >= 2)
                    {
                        if ((11 - resto2) == k)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else if (resto2 < 2)
                    {
                        if (resto2 == 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;

                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

    }
    public static bool Email(string email)
    {
        try
        {
            var Email = new System.Net.Mail.MailAddress(email);
            return Email.Address == email;
        }
        catch
        {
            return false;
        }
    }




    
}