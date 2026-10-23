var manager = new TaskManager();
var running = true;

while (running)
{
    Console.WriteLine();
    Console.WriteLine("=== TaskFlow ===");
    Console.WriteLine("1 - Adicionar tarefa");
    Console.WriteLine("2 - Listar tarefas");
    Console.WriteLine("3 - Concluir tarefa");
    Console.WriteLine("0 - Sair");
    Console.Write("Escolha uma opção: ");

    switch (Console.ReadLine())
    {
        case "1":
            AddTask(manager);
            break;
        case "2":
            ListTasks(manager);
            break;
        case "3":
            CompleteTask(manager);
            break;
        case "0":
            running = false;
            Console.WriteLine("Até logo!");
            break;
        default:
            Console.WriteLine("Opção inválida.");
            break;
    }
}

static void AddTask(TaskManager manager)
{
    Console.Write("Título da tarefa: ");
    try
    {
        var task = manager.AddTask(Console.ReadLine() ?? string.Empty);
        Console.WriteLine($"Tarefa adicionada: {task.Title}");
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine($"Erro: {ex.Message}");
    }
}

static void ListTasks(TaskManager manager)
{
    if (manager.Tasks.Count == 0)
    {
        Console.WriteLine("Nenhuma tarefa cadastrada.");
        return;
    }

    for (int i = 0; i < manager.Tasks.Count; i++)
    {
        var task = manager.Tasks[i];
        var mark = task.IsCompleted ? "x" : " ";
        Console.WriteLine($"{i + 1}. [{mark}] {task.Title}");
    }
}

static void CompleteTask(TaskManager manager)
{
    Console.Write("Número da tarefa: ");
    if (int.TryParse(Console.ReadLine(), out var number)
        && number >= 1 && number <= manager.Tasks.Count)
    {
        manager.CompleteTask(manager.Tasks[number - 1].Id);
        Console.WriteLine("Tarefa concluída!");
    }
    else
    {
        Console.WriteLine("Número inválido.");
    }
}
