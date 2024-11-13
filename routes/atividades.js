const express = require('express');
const router = express.Router();

/**
 * @swagger
 * /atividades:
 *   get:
 *     summary: Lista todas as atividades
 *     responses:
 *       200:
 *         description: Lista de atividades
 *         content:
 *           application/json:
 *             schema:
 *               type: array
 *               items:
 *                 type: object
 *                 properties:
 *                   id:
 *                     type: integer
 *                   nome:
 *                     type: string
 *                   horario:
 *                     type: string
 *                   descricao:
 *                     type: string
 */
router.get('/', (req, res) => {
  res.json([
    { id: 1, nome: 'Exercício', horario: '2024-11-12T08:00:00', descricao: 'Fazer exercício físico' },
  ]);
});

/**
 * @swagger
 * /atividades:
 *   post:
 *     summary: Cria uma nova atividade
 *     requestBody:
 *       required: true
 *       content:
 *         application/json:
 *           schema:
 *             type: object
 *             properties:
 *               nome:
 *                 type: string
 *               horario:
 *                 type: string
 *               descricao:
 *                 type: string
 *     responses:
 *       201:
 *         description: Atividade criada com sucesso
 */
router.post('/', (req, res) => {
  const novaAtividade = req.body;
  res.status(201).json(novaAtividade);
});

module.exports = router;
