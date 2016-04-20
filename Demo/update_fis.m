function fis=update_fis(stat)
%% This function update the rule base of the fuzzy logic controller according to the Q-values
% ------------------------------------------------------------------------
% Authors: Pooyan Jamshidi (pooyan.jamshidi@gmail.com)
% The code is released under the FreeBSD License.
% Copyright (C) 2016 Pooyan Jamshidi, Imperial College London
% The scripts implement Fuzzy Q-learning algorithm
% ------------------------------------------------------------------------


global NS FIS ACTION_2_VALUE

% initilize FIS
fis=FIS;

for rule_number=1:NS
    % choose the value and index of the optimum Q
    [maxQfactor,index]=max(stat.Q(rule_number,:));
    
    % update rule's consequent
    fis.rule(rule_number).consequent=index;
    
    % update value of the output associated with rule_number
    % linear: [a b c] ax+by+c
    % constant: [c] c

%     if strcmp(fis.output.mf(rule_number).type,'linear')
%         
%         fis.output.mf(rule_number).params(3)=ACTION_2_VALUE(index);
%         
%     elseif strcmp(fis.output.mf(rule_number).type,'constant')
%         
%         fis.output.mf(rule_number).params(1)=ACTION_2_VALUE(index);
%         
%     end
    
end

end