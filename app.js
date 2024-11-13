// Importar dependências necessárias
const express = require('express');
const swaggerJSDoc = require('swagger-jsdoc');
const swaggerUi = require('swagger-ui-express');

// Criar a instância do servidor Express
const app = express();
app.use(express.json()); // Para que o servidor entenda requisições com corpo JSON

// Configuração do Swagger
const swaggerOptions = {
  definition: {
    openapi: '3.0.1',
    info: {
      title: 'API de Organização de Rotina',
      version: '1.0.0',
      description: 'API para criar, gerenciar e consultar atividades na rotina',
    },
  },
  apis: ['./routes/*.js'], // Caminho para os arquivos de rotas
};

const swaggerSpec = swaggerJSDoc(swaggerOptions);

// Configurar o Swagger UI para exibir a documentação
app.use('/api-docs', swaggerUi.serve, swaggerUi.setup(swaggerSpec));

// Importar e usar as rotas definidas em outro arquivo (exemplo: atividades)
const atividadesRouter = require('./routes/atividades');
app.use('/atividades', atividadesRouter);

// Iniciar o servidor na porta 3000
app.listen(3000, () => {
  console.log('Servidor rodando na porta 3000');
});
