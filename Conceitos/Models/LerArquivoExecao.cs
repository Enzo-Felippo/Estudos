using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Conceitos.Models
{
    public class LerArquivoExecao
    {
        private void GerarErro()
        {
            // Usando o throw para gerar uma exeção
            throw new Exception("Eu escolhi gerar esse erro!!");
        }
        public void tentarLerArquivo(string caminho, bool erro)
        {
            try
            {
                if (erro)
                {
                    GerarErro();
                }
                string[] linhas = File.ReadAllLines(caminho);
                foreach (string linha in linhas)
                {
                    Console.WriteLine(linha);
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"Arquivo não encontrado. \n{ex.Message}");
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine($"Caminho da pasta não encontrado. \n{ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Aconteceu uma execão genérica. \n{ex.Message}");
            }
            finally
            {
                // Vai executar se der erro ou não
            }
        }
    }
}