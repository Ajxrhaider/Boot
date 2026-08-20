def take_magic_damage(health, resist, amp, spell_power):
    max_damage = amp*spell_power
    new_damage = max_damage - resist
    new_health = health - new_damage
    return new_health
