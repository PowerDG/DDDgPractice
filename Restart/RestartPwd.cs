     public virtual async Task<IdentityResult> ChangePasswordAsync(TUser user, string newPassword)
        {
            var result = await PasswordValidator.ValidateAsync(newPassword);
            if (!result.Succeeded)
            {
                return result;
            }

            await AbpStore.SetPasswordHashAsync(user, PasswordHasher.HashPassword(newPassword));
            return IdentityResult.Success;
        }