def player_status(health):
    if health <= 0:
        status = "dead"
    elif health <= 5:
        status = "injured"
    else:
        status = "healthy"
    return status