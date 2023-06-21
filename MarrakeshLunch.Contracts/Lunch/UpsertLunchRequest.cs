public record UpsertLunchRequest(
  Guid id,
  string Name,
  string Description,
  DateTime StartDateTime,
  DateTime EndDateTime,
  DateTime LastModifiedDateTime, 
  List<string> Savory,
  List <string> Sweet
);