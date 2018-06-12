//using frmMenuPrincipal.Dados.dsPrincipalTableAdapters;
//using frmMenuPrincipal.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using static frmMenuPrincipal.Dados.dsPrincipal;

//namespace frmMenuPrincipal.Util
//{
//    class Banco
//    {
//        #region Atributos @TableAdapter
//        private ClienteTableAdapter clientesTableAdapter = new ClienteTableAdapter();
//        private FuncionarioTableAdapter funcionariosTableAdapter = new FuncionarioTableAdapter();
//        private FornecedorTableAdapter fornecedoresTableAdapter = new FornecedorTableAdapter();
//        private FornecimentoTableAdapter fornecimentosTableAdapter = new FornecimentoTableAdapter();
//        private ProdutoTableAdapter produtosTableAdapter = new ProdutoTableAdapter();
//        private Produtos_AtendimentoTableAdapter produtosatendimentoTableAdapter = new Produtos_AtendimentoTableAdapter();
//        private Produtos_FornecimentoTableAdapter produtofornecimentoTableAdapter = new Produtos_FornecimentoTableAdapter();
//        private AtendimentoTableAdapter atendimentoTableAdapter = new AtendimentoTableAdapter();
//        #endregion
//        #region Cliente
//        /// <summary>
//        /// Overload do metódo "InserirCliente" do TableAdapter para suportar o objeto cliente
//        /// </summary>
//        /// <param name="cliente"> Objeto cliente, que devera conter todas as informações do cliente</param>
//        public void InsertCliente(Clientes cliente)
//        {
//            clientesTableAdapter.Insert(cliente.NomeCliente, cliente.IdentidadeCliente, cliente.EnderecoCliente, cliente.BairroCliente, cliente.TelefoneCliente, cliente.CelularCliente, cliente.EmailCliente, cliente.DataInfo);
//        }
//        /// <summary>
//        /// Overload do metódo SelectCliente do TableAdapter  
//        /// </summary>
//        /// <param name="iden">Identidade para se pesquisar um cliente </param>
//        /// <returns>DataTable com o cliente pesquisar </returns>
//        public ClienteDataTable SelectCliente(string iden)
//        {
//            return clientesTableAdapter.GetDataCliente(iden);
//        }
//        /// <summary>
//        /// Overload do metódo "UpdateCliente" do TableAdapter para suportar o objeto cliente
//        /// </summary>
//        /// <param name="cliente"> Objeto cliente, que devera conter todas as informações do cliente</param>
//        public void UpdateCliente(Clientes cliente)
//        {
//            ClienteDataTable clientedt = SelectCliente(cliente.IdentidadeCliente);
//            cliente.IdCliente = Convert.ToInt32(clientedt.Rows[0]["id_cliente"]);
//            clientesTableAdapter.Update(cliente.NomeCliente, cliente.IdentidadeCliente, cliente.EnderecoCliente, cliente.BairroCliente, cliente.TelefoneCliente, cliente.CelularCliente, cliente.EmailCliente, cliente.DataInfo);
//        }
//        public void DeleteCliente(Clientes cliente)
//        {
//            ClienteDataTable clientedt = SelectCliente(cliente.IdentidadeCliente);
//            clientesTableAdapter.deleteIdCliente(Convert.ToInt32(clientedt.Rows[0]["id_cliente"]));
//        }
//        public ClienteDataTable SelectCliente()
//        {
//            return clientesTableAdapter.GetData();
//        }
//        #endregion
//        #region Funcionario
//        /// <summary>
//        /// Overload do metódo "InserirFuncionario" do TableAdapter para suportar o objeto funcionario
//        /// </summary>
//        /// <param name="funcionario"> Objeto funcionario, que devera conter todas as informações do funcionario</param>
//        public void InsertFuncionario(Funcionario funcionario)
//        {
//            funcionariosTableAdapter.Insert(funcionario.Nome, funcionario.Identidade, funcionario.Cargo, funcionario.Cep, funcionario.Rua, funcionario.Numero, funcionario.Bairro, funcionario.Cidade, funcionario.Estado, funcionario.Telefone, funcionario.Celular, funcionario.Email, funcionario.DataInfo, funcionario.Obs);
//        }
//        /// <summary>
//        /// Overload do metódo SelectFuncionario do TableAdapter  
//        /// </summary>
//        /// <param name="iden">Identidade para se pesquisar um funcionario</param>
//        /// <returns>DataTable com o funcionario pesquisar</returns>
//        public FuncionarioDataTable SelectFuncionario(string iden)
//        {
//            return funcionariosTableAdapter.GetDataFuncionario(iden);
//        }
//        /// <summary>
//        /// Overload do metódo "UpdateFuncionario" do TableAdapter para suportar o objeto funcionario
//        /// </summary>
//        /// <param name="funcionario">Objeto funcionario, que devera conter todas as informações do funcionario</param>
//        public void UpdateFuncionario(Funcionario funcionario)
//        {
//            funcionariosTableAdapter.Update(funcionario.Nome, funcionario.Identidade, funcionario.Cargo, funcionario.Cep, funcionario.Rua, funcionario.Numero, funcionario.Bairro, funcionario.Cidade, funcionario.Estado, funcionario.Telefone, funcionario.Celular, funcionario.Email, funcionario.DataInfo, funcionario.Obs, funcionario.Id);
//        }
//        public FuncionarioDataTable SelectFuncionario()
//        {
//            return funcionariosTableAdapter.GetData();
//        }
//        public void DeleteFuncionario(Funcionario funcionario)
//        {
//            FuncionarioDataTable funcionariodt = SelectFuncionario(funcionario.IdFuncionario);
//            funcionariosTableAdapter.Delete(Convert.ToInt32(funcionariodt[0]["id_funcionario"]));
//        }
//        #endregion
//        #region Fornecimento
//        public FornecimentoDataTable SelectFornecimento()
//        {
//            return fornecimentosTableAdapter.GetData();
//        }
//        public FornecimentoDataTable SelectFornecimento(int id)
//        {
//            return fornecimentosTableAdapter.GetDataFornecimeto(id);
//        }
//        public void InsertFornecimento(Fornecimento fornecimento)
//        {
//            fornecimento.IdFornecimento = Convert.ToInt32(fornecimentosTableAdapter.InsertFornecimento(fornecimento.IdFornecedor, fornecimento.DataFornecimento));
//            InsertMultProdForn(fornecimento);
//        }
//        public void UpdateFornecimento(Fornecimento fornecimento)
//        {
//            fornecimentosTableAdapter.Update(fornecimento.DataInfo, fornecimento.Valor, fornecimento.IdFornecedor.Id, fornecimento.Obs, fornecimento.Id);
//        }
//        public void DeleteFornecimento(Fornecimento fornecimento)
//        {
//            fornecimentosTableAdapter.Delete(fornecimento.Id);
//        }
//        #endregion
//        #region Fornecedor
//        public FornecedorDataTable SelectFornecedor()
//        {
//            return fornecedoresTableAdapter.GetData();
//        }
//        public FornecedorDataTable SelectFornecedor(int id)
//        {
//            return fornecedoresTableAdapter.GetDataFornecedor(id);
//        }
//        public FornecedorDataTable SelectFornecedor(string iden)
//        {
//            return fornecedoresTableAdapter.GetDataFornecedorIden(iden);
//        }
//        public void InsertFornecedor(Fornecedor fornecedor)
//        {
//            fornecedoresTableAdapter.Insert(fornecedor.NomeFornecedor, fornecedor.IdentidadeFornecedor, fornecedor.EnderecoFornecedor, fornecedor.BairroFornecedor, fornecedor.TelefoneFornecedor, fornecedor.EmailFornecedor, fornecedor.DataInfo);
//        }
//        public void UpdateFornecedor(Fornecedor fornecedor)
//        {
//            fornecedoresTableAdapter.Update(fornecedor.NomeFornecedor, fornecedor.IdentidadeFornecedor, fornecedor.EnderecoFornecedor, fornecedor.BairroFornecedor, fornecedor.TelefoneFornecedor,
//                fornecedor.EmailFornecedor, fornecedor.DataInfo);
//        }
//        public void DeleteFornecedor(Fornecedor fornecedor)
//        {
//            fornecedoresTableAdapter.Delete(fornecedor.Id);
//        }
//        #endregion
//        #region Produto
//        public ProdutoDataTable SelectProduto()
//        {
//            return produtosTableAdapter.GetData();
//        }
//        public ProdutoDataTable SelectProduto(string nome)
//        {
//            return produtosTableAdapter.GetDataProdNome(nome);
//        }
//        public ProdutoDataTable SelectProduto(int id)
//        {
//            return produtosTableAdapter.GetDataProduto(id);
//        }
//        public void UpdateProduto(Produto produto)
//        {

//            produtosTableAdapter.Update(produto.IdFornecedor, produto.NomeProduto, produto.EstoqueProduto, produto.DataInfo);
//        }
//        public void InsertProduto(Produto produto)
//        {
//            produtosTableAdapter.Insert(produto.IdFornecedor, produto.NomeProduto, produto.EstoqueProduto, produto.DataInfo);
//        }
//        public void DeleteProduto(Produto produto)
//        {
//            produtosTableAdapter.Delete(produto.IdProduto);
//        }
//        //public void UpdateEstoqueVenda(ProdOper produto)
//        //{
//        //    produtosTableAdapter.UpdateEstoqueVenda(produto.Quantidade, produto.Produto.Id);
//        //}
//        //public void UpdateEstoqueFornecimento(ProdOper produto)
//        //{
//        //    produtosTableAdapter.UpdateEstoqueFornecimento(produto.Quantidade, produto.Produto.Id);
//        //}

//        #endregion
//        #region ProdOper
//        #region Venda
//        public Produtos_AtendimentoDataTable SelectProdutosVenda(Atendimento atendimento)
//        {
//            return produtosatendimentoTableAdapter.GetDataVenda(atendimento.IdAtendimento);
//        }
//        public Produtos_AtendimentoDataTable SelectProdutoVenda(Atendimento atendimento)
//        {
//            return produtosatendimentoTableAdapter.GetDataProdVenda(atendimento.IdAtendimento);
//        }
//        public void InsertProdutosAtendimento(atendimento venda, ProdOper produto)
//        {
//            produtostendimentoTableAdapter.Insert(venda.Id, produto.Produto.Id, produto.Quantidade);
//        }
//        public void InsertMultProdVenda(Venda venda)
//        {
//            foreach (ProdOper produto in venda.Produtos)
//            {
//                InsertProdutoVenda(venda, produto);
//                UpdateEstoqueVenda(produto);
//            }
//        }
//        #endregion
//        #region Fornecimento
//        public FORNECIMENTO_PRODUTODataTable SelectProdutosFornecimento(Fornecimento fornecimento)
//        {
//            return fornecimentoprodutoTableAdapter.GetDataFornecimento(fornecimento.Id);
//        }
//        public FORNECIMENTO_PRODUTODataTable SelectProdutosFornecimento(Produto produto)
//        {
//            return fornecimentoprodutoTableAdapter.GetDataProdFornecimento(produto.Id);
//        }
//        public void InsertProdutoForn(Fornecimento fornecimento, ProdOper produto)
//        {
//            fornecimentoprodutoTableAdapter.Insert(fornecimento.Id, produto.Produto.Id, produto.Quantidade);
//        }
//        public void InsertMultProdForn(Fornecimento fornecimento)
//        {
//            foreach (ProdOper produto in fornecimento.Produtos)
//            {
//                InsertProdutoForn(fornecimento, produto);
//                UpdateEstoqueFornecimento(produto);
//            }
//        }
//        #endregion
//        #endregion
//        #region Usuario
//        #endregion
//        #region Venda
//        /// <summary>
//        /// Overload do metódo "InserirFuncionario" do TableAdapter para suportar o objeto funcionario
//        /// </summary>
//        /// <param name="venda"> Objeto funcionario, que devera conter todas as informações do funcionario</param>
//        public void InsertVenda(Venda venda)
//        {
//            venda.Id = Convert.ToInt32(atendimentoTableAdapter.InsertVenda(venda.Cliente.Id, venda.Usuario.Id, venda.DataInfo, venda.Valor));
//            InsertMultProdVenda(venda);
//        }
//        /// <summary>
//        /// Overload do metódo SelectFuncionario do TableAdapter  
//        /// </summary>
//        /// <param name="id">Identidade para se pesquisar um funcionario</param>
//        /// <returns>DataTable com o funcionario pesquisar</returns>
//        public VENDASDataTable SelectVenda(int id)
//        {
//            return atendimentoTableAdapter.GetDataVenda(id);
//        }
//        /// <summary>
//        /// Overload do metódo "UpdateFuncionario" do TableAdapter para suportar o objeto funcionario
//        /// </summary>
//        /// <param name="venda">Objeto funcionario, que devera conter todas as informações do funcionario</param>
//        public void UpdateVenda(Venda venda)
//        {
//            atendimentoTableAdapter.Update(venda.Cliente.Id, venda.Usuario.Id, venda.DataInfo, venda.Valor, venda.Id);
//        }
//        public VENDASDataTable SelectVenda()
//        {
//            return atendimentoTableAdapter.GetData();
//        }
//        public void DeleteVenda(Venda venda)
//        {
//            VENDASDataTable vendadt = SelectVenda(venda.Id);
//            funcionariosTableAdapter.Delete(Convert.ToInt32(vendadt[0]["id_venda"]));
//        }
//        #endregion
//    }
//}
