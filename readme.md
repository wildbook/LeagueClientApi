LeagueClientApi
===============
This was part of an old project of mine that never got public.

As example for how to use it, here's a *very* simple and unstable insta-lock program for blind pick:
```cs
var championId = 517; // Champion to lock
var session = new LeagueClient().WaitUntilConnected();

session.OnSessionEnd += (_, __) => Environment.Exit(0);
session.RegisterEndpoint("/lol-champ-select/v1/session", async (LeagueEvent x) => {
    if (x.EventType != LeagueEventType.Create)
        return;
    
    var localCellId = (int) x.Data.localPlayerCellId;
    var actions = x.Data.actions[0];
    
    foreach (var action in actions)
    {
        var actorCellId = (int) action.actorCellId;
        if (actorCellId != localCellId)
            continue;
        
        var actionId = (int)action.id;
    
        await LeagueClientApi.Api.LolChampSelect.V1.Session.Actions.Patch(session, actionId,
            new LeagueClientApi.Model.LolChampSelectChampSelectAction
            {
                Completed = true,
                ChampionId = championId
            });
    
        Console.WriteLine($"Instalock: Completed.");
    }
}});
Thread.Sleep(-1);
```

If you want to actually use this for something and have questions, feel free to contact me.