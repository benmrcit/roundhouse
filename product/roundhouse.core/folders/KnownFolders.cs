namespace roundhouse.folders
{
    public interface KnownFolders
    {
        MigrationsFolder alter_database { get; }
        MigrationsFolder run_after_create_database { get; }
		MigrationsFolder run_before_up { get; }
        MigrationsFolder up { get; }
        MigrationsFolder down { get; }
        MigrationsFolder run_first_after_up { get; }
        MigrationsFolder functions { get; }
        MigrationsFolder views { get; }
        MigrationsFolder sprocs { get; }
        MigrationsFolder triggers { get; }
        MigrationsFolder indexes { get; }
        MigrationsFolder run_after_other_any_time_scripts { get; }
        MigrationsFolder permissions { get; }
        MigrationsFolder before_migration { get; }
        MigrationsFolder after_migration { get; }
        MigrationsFolder run_last_after_everything { get; }
        Folder change_drop { get; }
    }
}