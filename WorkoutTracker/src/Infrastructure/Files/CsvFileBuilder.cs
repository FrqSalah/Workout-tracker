﻿using System.Globalization;
using WorkoutTracker.Application.Common.Interfaces;
using WorkoutTracker.Application.TodoLists.Queries.ExportTodos;
using WorkoutTracker.Infrastructure.Files.Maps;
using CsvHelper;

namespace WorkoutTracker.Infrastructure.Files;

public class CsvFileBuilder : ICsvFileBuilder
{
    public byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records)
    {
        using var memoryStream = new MemoryStream();
        using (var streamWriter = new StreamWriter(memoryStream))
        {
            using var csvWriter = new CsvWriter(streamWriter, CultureInfo.InvariantCulture);

            csvWriter.Context.RegisterClassMap<TodoItemRecordMap>();
            csvWriter.WriteRecords(records);
        }

        return memoryStream.ToArray();
    }
}
